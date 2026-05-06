using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;
using NLog;
//using System.Speech.Synthesis;

namespace LDWordProcessor.nectec
{
    public delegate void TTSWordChangeEventHandler(string sWord, int iLength, int iPos);

    public class VajaTTS
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private SpVoice tts;
        private String text;
        private String curReadText;
        public event TTSWordChangeEventHandler WordChanged;
        public event EventHandler Stopped;
        public const string VAJA_TTS_NAME = "Vaja";

        enum VajvaStatus
        {
            Ready,
            Playing,
            Paused,
        }

        private VajvaStatus status;

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public VajaTTS(){
            tts = new SpVoice();
            SetVoice(Properties.Settings.Default.TTSName);
            tts.Word += new _ISpeechVoiceEvents_WordEventHandler(OnWordChange);
            tts.EndStream += new _ISpeechVoiceEvents_EndStreamEventHandler(OnEndStream);

            //SpeechSynthesizer ss = new SpeechSynthesizer();
            //foreach (var v in ss.GetInstalledVoices())
            //{
            //    logger.Debug(v.VoiceInfo.Name);
            //}
        }

        public bool SetVoice(string voiceName)
        {
            foreach (ISpeechObjectToken v in tts.GetVoices())
            {
                logger.Debug(v.GetDescription());
                if (v.GetDescription().IndexOf(voiceName)>-1)
                {
                    tts.Voice = (SpObjectToken) v;
                    return true;
                }
            }

            return false;
        }

        public bool IsVajaVoice()
        {
            return tts.Voice.GetDescription().IndexOf(VAJA_TTS_NAME)>-1;
        }

        public void Play()
        {
            if (status == VajvaStatus.Paused)
            {
                status = VajvaStatus.Playing;
                tts.Resume();
            }
            else
            {
                if (Text.Trim().Length > 0)
                {
                    curReadText = Text;
                    try
                    {
                        logger.Debug("Read Text: {0}", curReadText);
                        tts.Speak(curReadText, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                    }
                    catch (Exception e)
                    {
                        logger.Error(e);
                    }
                    status = VajvaStatus.Playing;
                }
            }
        }

        public void PlayButton()
        {
            
                if (Text.Trim().Length > 0)
                {
                    curReadText = Text;
                    try
                    {
                        logger.Debug("Read Text: {0}", curReadText);
                    tts.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
                        tts.Speak(curReadText, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                    }
                    catch (Exception e)
                    {
                        logger.Error(e);
                    }
                    status = VajvaStatus.Playing;
                }
            
        }


        public bool isPlaying() {
            if (status == VajvaStatus.Playing)
            {
                return true;
            }
            else {
                return false;
            }

        }

        public void Pause()
        {
            if (status == VajvaStatus.Playing)
            {
                tts.Pause();
                status = VajvaStatus.Paused;
            }
        }

        public void Stop()
        {
            tts.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
            if (status != VajvaStatus.Ready)
            {
                try
                {
                    //reader.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
                    //tts.Pause();
                    
                    
                    status = VajvaStatus.Ready;
                }
                catch (Exception e)
                {    }
            }
        }

        private void OnWordChange(int StreamNumber, object StreamPosition, int CharacterPosition, int Length)
        {
            if (WordChanged != null)
            {
                if ((CharacterPosition+Length <= curReadText.Length))
                {
                    string s = curReadText.Substring(CharacterPosition, Length);
                    WordChanged(s, Length, CharacterPosition);
                }
            }
            //logger.Debug("StreamNumber={0}, StreamPosition={1}, CharacterPosition={2}, Length={3}", StreamNumber,  StreamPosition,  CharacterPosition,  Length);
        }

        protected void OnEndStream(int StreamNumber, object StreamPosition)
        {
            status = VajvaStatus.Ready;

            if (Stopped != null)
            {
                Stopped(this, new EventArgs());
            }
            //logger.Debug("End stream");
        }

        public int Speed
        {
            get { return tts.Rate; }
            set { tts.Rate = value; }
        }

        public int Volume
        {
            get { return tts.Volume; }
            set { tts.Volume = value; }
        }
    }
}
