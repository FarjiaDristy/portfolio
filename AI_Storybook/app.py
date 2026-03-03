from flask import Flask, request, jsonify
from flask_cors import CORS
import requests
import os
from dotenv import load_dotenv

load_dotenv()

app = Flask(__name__)
CORS(app)

API_KEY = os.getenv("GEMINI_API_KEY")
API_URL = f"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={API_KEY}"


@app.route('/api/generate-story', methods=['POST'])
def generate_story():
    """Generate a story using the Gemini API"""
    try:
        data = request.json
        prompt = data.get('prompt', '').strip()

        if not prompt:
            return jsonify({'error': 'No prompt provided'}), 400

        enhanced_prompt = f'''Create a captivating, well-structured story based on this prompt: "{prompt}". 
        Make it feel like a classic storybook tale, around 2000-3000 words.'''

        response = requests.post(API_URL, json={
            'contents': [{'parts': [{'text': enhanced_prompt}]}],
            'generationConfig': {'temperature': 0.8, 'maxOutputTokens': 4000}
        })

        if not response.ok:
            return jsonify({'error': f'API error: {response.status_code}'}), response.status_code

        data = response.json()
        story = data.get('candidates', [{}])[0].get(
            'content', {}).get('parts', [{}])[0].get('text', '')

        if not story:
            return jsonify({'error': 'No story generated'}), 500

        return jsonify({'story': story}), 200

    except Exception as e:
        return jsonify({'error': str(e)}), 500


if __name__ == '__main__':
    app.run(debug=False, port=5000)
