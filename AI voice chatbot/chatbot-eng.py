import pyttsx3
import speech_recognition as sr 
import datetime
import wikipedia
import webbrowser
import os
import pyautogui
import pywhatkit
import pyjokes 
import openai
import time

engine = pyttsx3.init('sapi5')
voices = engine.getProperty('voices')
engine.setProperty('voice', voices[0].id)


def speak(audio):
    engine.say(audio)
    engine.runAndWait()


def wishMe():  

    speak("how may I help you")       

def takeCommand():

    r = sr.Recognizer()
    with sr.Microphone() as source:
        print("Listening...")
        r.pause_threshold = 1
        audio = r.listen(source)

    try:
        print("Recognizing...")    
        query = r.recognize_google(audio, language='en-in')
        print(f"User said: {query}\n")
        
    except Exception as e:
          
        speak("i did not get it")
    
        return"f"
    return query
       
   


if __name__ == "__main__":
    wishMe()
    while True:
    
        query = takeCommand().lower()

       
        if 'wikipedia' in query:
            speak('Searching Wikipedia...')
            query = query.replace("wikipedia", "")
            results = wikipedia.summary(query, sentences=2)
            speak("According to Wikipedia")
            print(results)
            speak(results)

        elif 'exit' in query:
                speak('ok Goodbye')
                exit()



        elif 'open google' in query:
            webbrowser.open("google.com")
   

        elif "launch" in query:
                    query = query.replace("launch","")
                    query = query.replace("micky","")
                    pyautogui.press("super")
                    pyautogui.typewrite(query)
                    pyautogui.press("enter")  

                    speak('lanching')

        elif 'play' in query:
            song = query.replace('play', '')
            speak('playing ' + song)
            pywhatkit.playonyt(song)

        elif 'time' in query:
            time = datetime.datetime.now().strftime('%I:%M %p')
            print(time)
            speak('Current time is ' + time)

        elif 'open from movie' in query:
            spc = query.replace("open from movie","")
            movie = "movie\\"+spc
            os.startfile(movie)
            speak('opening')
        elif 'open from webserise' in query:
            spc = query.replace("open from webserise","")
            movie = "webserise\\"+spc
            os.startfile(movie)
            speak('opening')
        elif "google" in query:
            ssearch = query.replace('google', '')
            speak('I am going to search it for you')
            pywhatkit.search(ssearch)
        
        
        elif 'joke' in query:
            speak(pyjokes.get_joke())



        elif "imagine" in query:
            spk=query.replace("imagine","")
            openai.api_key= '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'
            response = openai.Image.create(
            prompt=spk,n=1,size="1024x1024")
            image_url = response['data'][0]['url']
            cv=(image_url)
            os.startfile(cv)
            speak("imagining")


        elif "draw" in query:
         sdc=query.replace("draw","")

        
         openai.api_key= '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'
         response = openai.Image.create(
         prompt='draw with color'+sdc,n=1,size="1024x1024")
         image_url = response['data'][0]['url']
         cv=(image_url)
         os.startfile(cv)
         speak("drawing")

        elif 'open' in query:
                app = query.replace('open', '').strip()
                os.startfile(app + '.exe')
                speak(f'Opening {app}')
        
    
    


        elif"mickey"in query:

            with open("voice.py") as f:
                code = compile(f.read(), "voice.py", 'exec')
                exec(code)

        else:
             speak("please say that again!")













        
