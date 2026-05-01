# --- Persist user voice settings ---
if "voice_accent" not in st.session_state:
    st.session_state["voice_accent"] = "uk"
if "voice_volume" not in st.session_state:
    st.session_state["voice_volume"] = 0.8
if "voice_mute" not in st.session_state:
    st.session_state["voice_mute"] = False
