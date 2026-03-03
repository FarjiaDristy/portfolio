# Enchanted Storybook AI

An interactive AI-powered storybook generator using Google's Gemini API.

## Setup Instructions

### 1. Clone the Repository

```bash
git clone <your-repo-url>
cd <repo-folder>
```

### 2. Create a `.env` File

Create a `.env` file in the project root with your API key:

```
GEMINI_API_KEY=your_api_key_here
```

**Important:** This file is in `.gitignore` and will NOT be pushed to GitHub.

### 3. Install Dependencies

```bash
pip install -r requirements.txt
```

### 4. Run the Backend

```bash
python app.py
```

The server will start on `http://localhost:5000`

### 5. (Optional) Use Streamlit Instead of HTML

You can replace the separate HTML frontend with a Streamlit app that bundles UI and backend together. After installing the dependencies (Streamlit is already in `requirements.txt`), run:

```bash
streamlit run streamlit_app.py
```

A browser window (usually at `http://localhost:8501`) will open. Enter a prompt and click **Weave My Story**; click the navigation buttons to move between pages.

### 6. Open the Frontend

Open `AIStorybook.html` in your browser or serve it with a local server:

```bash
# Using Python
python -m http.server 8000

# Then navigate to http://localhost:8000/AIStorybook.html
```

## Features

- Generate unique stories with AI prompts
- Beautiful page-flipping animation
- Responsive design with magical background effects
- Keyboard navigation (Arrow keys, Space, Right-click)

## Deployment

For production deployment, you'll need to host the backend server (Heroku, Railway, Render, etc.) and update the `apiUrl` in the HTML to point to your hosted backend URL.

## Security

- API keys are stored in `.env` and never committed to Git
- The backend handles all API requests securely
- CORS is enabled for frontend communication
