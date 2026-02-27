import streamlit as st
import google.generativeai as genai
import json

# --- 1. CONFIGURATION & API ---
st.set_page_config(page_title="Enchanted Storybook AI", layout="wide")

# Check for API Key in secrets (for GitHub/Deployment)
# If running locally without secrets, it falls back to your provided key
if "GEMINI_API_KEY" in st.secrets:
    API_KEY = st.secrets["GEMINI_API_KEY"]
else:
    API_KEY = "secretapikey"

genai.configure(api_key=API_KEY)

# --- 2. THE MAGICAL FRONTEND (HTML/CSS/JS) ---
def render_storybook(story_text=None, is_loading=False):
    # This is your exact HTML/CSS from the original project
    html_code = f"""
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8" />
      <style>
        @import url('https://fonts.googleapis.com/css2?family=Crimson+Text:ital,wght@0,400;0,600;1,400&family=Dancing+Script:wght@400;700&display=swap');
        * {{ margin: 0; padding: 0; box-sizing: border-box; }}
        
        body {{
          font-family: 'Crimson Text', serif;
          background: transparent; /* Streamlit handles the outer bg */
          overflow: hidden;
          padding: 10px;
        }}

        .story-section {{
          background: rgba(255, 255, 255, 0.95);
          backdrop-filter: blur(20px);
          border-radius: 25px;
          padding: 40px;
          width: 100%;
          height: 650px;
          box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1), inset 0 1px 0 rgba(255, 255, 255, 0.6);
          border: 1px solid rgba(255, 255, 255, 0.3);
          display: flex;
          flex-direction: column;
          position: relative;
        }}

        .story-header {{
          font-family: 'Dancing Script', cursive;
          font-size: 2.5rem;
          color: #667eea;
          text-align: center;
          margin-bottom: 25px;
        }}

        .story-pages {{ 
          flex: 1; display: flex; width: 100%; height: 500px; 
          overflow: hidden; position: relative; perspective: 1000px;
        }}

        .story-page {{ 
          width: 100%; height: 100%; overflow: hidden; padding: 20px; 
          cursor: pointer; transition: transform 0.8s ease-in-out;
          position: relative; transform-style: preserve-3d; backface-visibility: hidden;
        }}
        
        .flipping-forward {{ animation: flipForward 0.8s ease-in-out; }}
        .flipping-backward {{ animation: flipBackward 0.8s ease-in-out; }}
        
        @keyframes flipForward {{
          0% {{ transform: rotateY(0deg); }}
          50% {{ transform: rotateY(-90deg); }}
          100% {{ transform: rotateY(0deg); }}
        }}
        
        @keyframes flipBackward {{
          0% {{ transform: rotateY(0deg); }}
          50% {{ transform: rotateY(90deg); }}
          100% {{ transform: rotateY(0deg); }}
        }}

        .story-page p {{ font-size: 1.2rem; line-height: 1.8; margin-bottom: 1rem; text-align: justify; color:#333; }}
        .story-page p:first-child::first-letter {{
          font-size: 4rem; font-family: 'Dancing Script', cursive;
          float: left; margin: 0 8px 0 0; color: #667eea;
        }}

        .pagination-controls {{
          display: flex; justify-content: center; align-items: center;
          gap: 15px; position: absolute; bottom: 30px; left: 0; width: 100%;
          pointer-events: none;
        }}

        .pagination-controls span {{
          pointer-events: auto; background: rgba(255,255,255,0.85);
          padding: 6px 18px; border-radius: 10px; color:#667eea; font-weight:600;
        }}

        .story-placeholder {{
          color: #999; font-style: italic; text-align: center;
          padding: 60px 20px; font-size: 1.3rem;
        }}
      </style>
    </head>
    <body>
      <div class="story-section">
        <h2 class="story-header">Your Enchanted Tale</h2>
        <div id="storyContent">
            <div class="story-placeholder">
                {"Crafting your enchanted tale..." if is_loading else "Your magical story will appear here..."}
            </div>
        </div>
      </div>

      <script>
        const storyData = {json.dumps(story_text)};
        let pages = [];
        let currentPageIndex = 0;

        function processPages(text) {{
          const container = document.getElementById('storyContent');
          // Hidden measuring container
          container.innerHTML = `<div id="measure" style="visibility:hidden; position:absolute; width:100%; padding:20px;"></div>`;
          const measure = document.getElementById('measure');
          const paragraphs = text.split('\\n').filter(p => p.trim());
          
          let currentPageContent = [];
          const maxHeight = 420; // Adjusted for the container

          paragraphs.forEach(p => {{
            const testDiv = document.createElement('div');
            testDiv.innerHTML = currentPageContent.map(para => `<p>${{para}}</p>`).join('') + `<p>${{p}}</p>`;
            measure.appendChild(testDiv);
            
            if (testDiv.offsetHeight > maxHeight) {{
              if (currentPageContent.length > 0) {{
                pages.push(currentPageContent.map(para => `<p>${{para}}</p>`).join(''));
              }}
              currentPageContent = [p];
            }} else {{
              currentPageContent.push(p);
            }}
            measure.removeChild(testDiv);
          }});
          
          if (currentPageContent.length > 0) {{
            pages.push(currentPageContent.map(para => `<p>${{para}}</p>`).join(''));
          }}
          renderPage();
        }}

        function renderPage() {{
          const container = document.getElementById('storyContent');
          if (pages.length === 0) return;
          
          const content = pages[currentPageIndex];
          container.innerHTML = `
            <div class="story-pages">
              <div class="story-page" id="currentPage">${{content}}</div>
            </div>
            <div class="pagination-controls">
              <span>Page ${{currentPageIndex + 1}} of ${{pages.length}}</span>
            </div>
          `;

          const pageEl = document.getElementById('currentPage');
          pageEl.addEventListener('click', () => {{
            if (currentPageIndex < pages.length - 1) flipToPage(currentPageIndex + 1, 'forward');
          }});
          pageEl.addEventListener('contextmenu', (e) => {{
            e.preventDefault();
            if (currentPageIndex > 0) flipToPage(currentPageIndex - 1, 'backward');
          }});
        }}

        function flipToPage(idx, dir) {{
          const el = document.getElementById('currentPage');
          el.classList.add(dir === 'forward' ? 'flipping-forward' : 'flipping-backward');
          setTimeout(() => {{
            currentPageIndex = idx;
            renderPage();
          }}, 400);
        }}

        if (storyData) {{ processPages(storyData); }}
      </script>
    </body>
    </html>
    """
    st.components.v1.html(html_code, height=700)

# --- 3. STREAMLIT UI LAYOUT ---
# Injecting the magical background CSS globally
st.markdown("""
<style>
    .stApp {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    }
    /* Styling the Streamlit Sidebar to match your design */
    [data-testid="stSidebar"] {
        background-color: rgba(255, 255, 255, 0.9);
        backdrop-filter: blur(10px);
    }
    .main-title {
        font-family: 'Dancing Script', cursive;
        font-size: 3.5rem;
        color: white;
        text-align: center;
        margin-bottom: 0;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.2);
    }
    .sub-title {
        color: #e1e8ed;
        text-align: center;
        font-style: italic;
        margin-bottom: 30px;
    }
</style>
<h1 class="main-title">Enchanted Storybook</h1>
<p class="sub-title">Where AI weaves tales of wonder</p>
""", unsafe_allow_html=True)

# Create the two-column layout from your original design
col1, col2 = st.columns([1, 1], gap="large")

with col1:
    # This mimics your "input-section"
    st.markdown('<div style="background: rgba(255,255,255,0.95); padding: 30px; border-radius: 25px; box-shadow: 0 10px 30px rgba(0,0,0,0.1);">', unsafe_allow_html=True)
    
    prompt_input = st.text_area("Enter your story spark:", placeholder="e.g., A dragon who runs a cozy bookstore...", height=150)
    
    # Custom styled button
    if st.button("✨ Weave My Story ✨"):
        if prompt_input:
            with st.spinner("Writing magic..."):
                try:
                    model = genai.GenerativeModel('gemini-2.0-flash')
                    full_prompt = f"Write a long, enchanting storybook tale about: {prompt_input}. The story MUST be long enough to fill 6-8 pages (approx 1200 words). Use rich, magical language."
                    response = model.generate_content(full_prompt)
                    st.session_state.story = response.text
                except Exception as e:
                    st.error(f"The magic failed: {e}")
        else:
            st.warning("Please enter a story idea first!")

    st.markdown("---")
    st.markdown("### Story Spark Ideas:")
    example_prompts = [
        "A dragon who runs a cozy bookstore",
        "Time-traveling baker's future recipes",
        "Lighthouse keeper guiding lost souls",
        "Playground equipment comes alive at night"
    ]
    for ex in example_prompts:
        if st.button(ex, key=ex):
            # In a real app, you'd use a callback, but for simplicity, just copy-paste is fine
            st.info(f"Copy this: {ex}")
    st.markdown('</div>', unsafe_allow_html=True)

with col2:
    # This mimics your "story-section"
    if "story" in st.session_state:
        render_storybook(st.session_state.story)
    else:
        render_storybook()
