import os
import requests
import streamlit as st
from dotenv import load_dotenv

load_dotenv()

API_KEY = os.getenv("GEMINI_API_KEY")
API_URL = (
    f"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={API_KEY}"
)


# split text into pages based on approximate height (simple paragraph splitting)
def paginate_story(text, max_chars=1000):
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


def generate_story(prompt: str) -> str:
    prompt = prompt.strip()
    if not prompt:
        return ""

    enhanced_prompt = (
        f"Create a captivating, well-structured story based on this prompt: \"{prompt}\". "
        "Make it feel like a classic storybook tale, around 2000-2200 words."
    )

    try:
        resp = requests.post(
            API_URL,
            json={
                "contents": [{"parts": [{"text": enhanced_prompt}]}],
                "generationConfig": {"temperature": 0.8, "maxOutputTokens": 4000},
            },
            timeout=15,
        )
    except requests.exceptions.Timeout:
        st.error("Request timed out, please try again later.")
        return ""
    except requests.exceptions.RequestException as exc:
        st.error(f"Request error: {exc}")
        return ""

    if not resp.ok:
        st.error(f"API returned {resp.status_code}")
        return ""
    data = resp.json()
    story = (
        data.get("candidates", [{}])[0]
        .get("content", {})
        .get("parts", [{}])[0]
        .get("text", "")
    )
    return story.strip()


def main():
    st.set_page_config(page_title="Enchanted Storybook", layout="centered")
    st.title("✨ Enchanted Storybook ✨")
    st.write("_Where AI weaves tales of wonder_")

    prompt = st.text_area("Enter your story idea", height=150)

    if st.button("Weave My Story"):
        if not prompt.strip():
            st.warning("Please enter a prompt before generating.")
        else:
            with st.spinner("Crafting your enchanted tale..."):
                story_text = generate_story(prompt)
            if story_text:
                pages = paginate_story(story_text)
                if "page_index" not in st.session_state:
                    st.session_state.page_index = 0

                def show_current_page():
                    idx = st.session_state.page_index
                    st.write(f"### Page {idx+1} of {len(pages)}")
                    st.markdown(pages[idx])

                show_current_page()
                col1, col2, col3 = st.columns([1, 2, 1])
                if col1.button("← Previous") and st.session_state.page_index > 0:
                    st.session_state.page_index -= 1
                    show_current_page()
                if col3.button("Next →") and st.session_state.page_index < len(pages) - 1:
                    st.session_state.page_index += 1
                    show_current_page()


if __name__ == "__main__":
    main()
