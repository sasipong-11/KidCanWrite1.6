using System;
using api;
namespace CoreVaja
{
	class Core
	{
        private CoreLib _cl;
        public string filepath;
        public int speed = 0;
        public Core()
        {
            this._cl = new CoreLib("M@nZa#10");
            // change file other program
            this.filepath = @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\tws1.wav";
        }
        /** WordSegment **/
        public string getWordSeg(string text)
        {
            try
            {
                return this._cl.GetWordSeg(text);            
            }
            catch { return ""; }
        }
        public string getWordSegLast()
        {
            return this._cl.WORDSEGMENT;
        }
        public int getWordSegCountLast()
        {
            return this._cl.WORDSEGMENT_COUNT;
        }
        /** G2P **/
        public string getG2PbyWordSeg(string wordSeg){
            try
            {
                return this._cl.GetG2P(_cl.GetWordSeg(wordSeg));
            }
            catch { return ""; }
        }
        public string getG2P(string word)
        {
            return this._cl.GetG2P(word);
        }
        public string getG2PLast()
        {
            return this._cl.PHONEME;
        }
        /** Synthesis **/
        public bool genSynthesis(string text)
        {
            try
            {
                return this._cl.GenSynthesis(this.getG2PbyWordSeg(text), this.filepath, this.speed, 80, "wav");
            }
            catch { return false; }
        }
        public bool genSynthesisLast()
        {
            return this._cl.SYNTHESIS;
        }
        /** speed **/
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public int getSpeed()
        {
            return this.speed;
        }
	}
}
