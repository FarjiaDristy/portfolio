import os
import requests
import streamlit as st
from dotenv import load_dotenv

load_dotenv()

print("streamlit_app imported")


def paginate_story(text, max_chars=1000):
    """Split text into pages based on character count."""
    paragraphs = [p.strip() for p in text.split("\n") if p.strip()]
    pages = []
    current = ""
    for p in paragraphs:
        if len(current) + len(p) + 1 > max_chars:
            pages.append(current)
            current = p + "\n\n"
        else:
            current += p + "\n\n"
    if current:
        pages.append(current)
    return pages


def generate_story(prompt: str, api_url: str) -> str:
    """Generate a story using the Gemini API.

    Args:
        prompt: The user's story prompt
        api_url: The full Gemini API endpoint URL with key

    Returns:
        Generated story text, or empty string on error
    """
    prompt = prompt.strip()
    if not prompt:
        return ""
    if not api_url:
        st.error("Server configuration error: API URL not set.")
        return ""

    enhanced_prompt = (
        f"Create a captivating, well-structured story based on this prompt: \"{prompt}\". "
        "Make it feel like a classic storybook tale, around 1500-2500 words."
    )

    try:
        resp = requests.post(
            api_url,
            json={
                "contents": [{"parts": [{"text": enhanced_prompt}]}],
                "generationConfig": {"temperature": 0.8, "maxOutputTokens": 3000},
            },
            timeout=20,
        )
    except requests.exceptions.Timeout:
        st.error(
            "Request timed out. The API took too long to respond. Please try again.")
        return ""
    except requests.exceptions.RequestException as exc:
        st.error(f"Network error: {exc}")
        return ""
    except Exception as exc:
        st.error(f"Unexpected error: {exc}")
        return ""

    if not resp.ok:
        st.error(f"API error {resp.status_code}: {resp.text[:200]}")
        return ""

    try:
        data = resp.json()
    except Exception as exc:
        st.error(f"Failed to parse API response: {exc}")
        return ""

    story = (
        data.get("candidates", [{}])[0]
        .get("content", {})
        .get("parts", [{}])[0]
        .get("text", "")
    )

    if not story:
        st.error("API returned empty story. Try a different prompt.")
        return ""

    return story.strip()


def main():
    st.set_page_config(page_title="Enchanted Storybook", layout="centered")
    st.title("✨ Enchanted Storybook ✨")
    st.write("_Where AI weaves tales of wonder_")

    # Get API key from Streamlit secrets
    api_key = st.secrets.get("GEMINI_API_KEY")
    if not api_key:
        st.error(
            "❌ API key not found. Please add `GEMINI_API_KEY` to Streamlit Secrets.")
        st.info("For local testing, add it to your `.env` file. For Streamlit Cloud, set it in the app's Secrets panel.")
        return

    api_url = f"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={api_key}"

    # Input section
    st.subheader("📝 Tell me your story idea:")
    prompt = st.text_area("Enter your story prompt", height=120,
                          placeholder="e.g., A dragon who runs a cozy bookstore...")

    # Generate button
    if st.button("✨ Weave My Story ✨", use_container_width=True):
        if not prompt.strip():
            st.warning("Please enter a prompt before generating.")
        else:
            with st.spinner("🎨 Crafting your enchanted tale..."):
                story_text = generate_story(prompt, api_url)

            if story_text:
                pages = paginate_story(story_text)

                # Initialize session state for pagination
                if "page_index" not in st.session_state:
                    st.session_state.page_index = 0

                # Clamp page index to valid range
                st.session_state.page_index = max(
                    0, min(st.session_state.page_index, len(pages) - 1))

                # Navigation buttons (BEFORE displaying content)
                st.divider()
                col1, col2, col3 = st.columns([1, 2, 1])

                with col1:
                    if st.button("← Previous", use_container_width=True):
                        if st.session_state.page_index > 0:
                            st.session_state.page_index -= 1

                with col3:
                    if st.button("Next →", use_container_width=True):
                        if st.session_state.page_index < len(pages) - 1:
                            st.session_state.page_index += 1

                # Display current page (AFTER button updates)
                st.divider()
                idx = st.session_state.page_index
                st.write(f"**Page {idx + 1} of {len(pages)}**")
                st.markdown(pages[idx])
                st.divider()


if __name__ == "__main__":
    main()
