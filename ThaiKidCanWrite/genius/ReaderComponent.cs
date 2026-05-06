using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using LDWordProcessor.nectec;

namespace LDWordProcessor
{
    public partial class ReaderComponent : Component
    {
        private VajaTTS iReader;

        public event TTSWordChangeEventHandler WordChanged;
        public event EventHandler Stopped;
        private bool isPlaying;

        public ReaderComponent()
        {
            InitializeComponent();
            Init();
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnWordChanged(string sWord,int iLength, int iPos)
        {
            if (WordChanged != null)
                WordChanged(sWord, iLength, iPos);
        }

        protected virtual void OnStopped(object sender, EventArgs e)
        {
            if (Stopped != null)
                Stopped(sender, e);
        }

        public ReaderComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string ExeAppPath = Environment.CurrentDirectory;
            iReader = new VajaTTS();
            iReader.WordChanged += new TTSWordChangeEventHandler(OnWordChanged);
            iReader.Stopped += new EventHandler(OnStopped);
        }

        public string Text
        {
            get{
                return iReader.Text;
            }
            set{
                iReader.Text = value;
            }
        }

        public int Speed
        {
            get { return iReader.Speed; }
            set { iReader.Speed = value; }
        }

        public int Volume
        {
            get { return iReader.Volume; }
            set { iReader.Volume = value; }
        }

        public void Play()
        {
            iReader.Play();
            isPlaying = true;
          /*  iReader.Pause();
            isPlaying = false;
            if (isPlaying == true)
            {

                Console.WriteLine("play-->");
            }
            else
            {
                Console.WriteLine("stop-->");

            }*/
           

        }

        public void Stop()
        {
           /* if (isPlaying == true)
            {

                Console.WriteLine("play-->");
            }
            else
            {
                Console.WriteLine("stop-->");

            }*/
           // iReader.Stop();
            iReader.Pause();
            isPlaying = false;

           



        }

        public void Pause()
        {
            iReader.Pause();
            isPlaying = false;
        }

        public bool IsVajaVoice{
            get{ return iReader.IsVajaVoice(); }
        }
        
    }
}
