using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DevExpress.XtraRichEdit.API.Native;
using System.Security.Cryptography;
using NLog;
using LDWordProcessor.genius;
using WordProcLD;

using System.IO;

using System.Text.RegularExpressions;
using System.Threading;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

#pragma warning disable 0168
#pragma warning disable 0169
#pragma warning disable 0219
#pragma warning disable 0414

namespace LDWordProcessor
{
    public class SegmentSolution
    {

        private string sText;
        private string mText;
        private List<WordSegmentEntry> list = new List<WordSegmentEntry>();
        //   private System.Collections.ArrayList list;
        private FileStream fs;
        private StreamReader sr;

        private uint nPeopleToRing;
        private bool isDisposed = false;
        private bool isOpen = false;
        private LDSpellChecker iSpellChecker;
        private int index = 0;
        // private List<string> wrongWord = new List<string>();
        private SpellWordSuggestEntry[] suggestWords;
        // private LDParagraph parent;
        private string[] suggestWord;

        private SpellWordSuggestEntry[] suggestLD;
        private string[] status;
        private int pointer = 0, currPos = 0;
        WordSegmentEntry[] currentSeg;

        LDSpellChecker checker;


        

        public void cleanLongText()
        {
            string word = "", wd = "", cmp = "";

            if (suggestWord.Length > 2)
            {

                for (int i = 0; i < suggestWord.Length; i++)
                {

                    // Console.WriteLine("wr-->{0}", suggestWord[i]);
                    word = "";
                    wd = "";
                    //  if (i < suggestWord.Length - 1)
                    // {
                    try { cmp = status[i + 1].ToString(); }

                    catch (System.IndexOutOfRangeException e)
                    {
                        cmp = status[i].ToString();

                    }
                    if (string.Compare(cmp, "0") == 0)
                    {
                        for (int counter = i; counter < i + 1; counter++)
                        {
                            wd += suggestWord[counter];


                        }
                       //  Console.WriteLine("wd-->{0}", wd);
                      //  string endChk = list[pointer - 1].text + wd;
                      //  int chkSound = checkSoundex(endChk);

                     //   if (chkSound == 0)
                     //   {
                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = wd;
                            ws1.length = wd.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                      //  }
                      //  else {
//
                     //      list[pointer - 1].text +=wd;
                      //  }

                    }
                    // }
                    else
                    {
                       // Console.WriteLine("suggestWord.Length-->{0}--i-->{1}", suggestWord.Length,i);
                       // if((suggestWord.Length-i)<=5)
                       // {
                        for (int j = i; j < suggestWord.Length; j++)
                        {
                            // suggestWord[];

                            if ((!Regex.IsMatch(suggestWord[j], " ")))
                                word += suggestWord[j];
                            else {

                                WordSegmentEntry ws1 = new WordSegmentEntry();

                                ws1.text = suggestWord[j];
                                ws1.length = suggestWord[j].Length;
                                // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                //chkSound = suggestWords.Length;
                                list.Add(ws1);
                                pointer++;


                            }


                        }
                         Console.WriteLine("wd2-->{0}", word);
                        int chkSound = checkSoundex(word);
                       // Console.WriteLine("chkSound-->{0}", chkSound);
                        if (chkSound == 0)
                        {

                            //  Console.WriteLine("word-->{0}", word);
                            suggestLD = LDSuggestWord.GetSuggestLDWords(word);
                            Console.WriteLine("suggestLD-->{0}", suggestLD.Count());
                            if (suggestLD.Count() > 0)
                            {
                                // for (int cp = 0; cp < suggestLD.Count(); cp++)
                               // Console.WriteLine("suggestLD1-->{0}", word);
                                string wordChk = "";
                                try
                                {
                                    wordChk = word + currentSeg[currPos + 1].text;
                                    //   Console.WriteLine("suggestChk1-->{0}", suggestChk);
                                }
                                catch (System.IndexOutOfRangeException e)  // CS0168
                                {
                                    //System.Console.WriteLine(e.Message);
                                    wordChk = word;
                                    //set IndexOutOfRangeException to the new exception's InnerException
                                    //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                }
                                //  suggestLD = LDSuggestWord.GetSuggestLDWords(wordChk);
                                if (LDSuggestWord.GetSuggestLDWords(wordChk).Count() == 0)
                                {
                                    /*currentSeg[currPos].text = word;
                                    currentSeg[currPos].length = word.Length;
                                    list.Add(currentSeg[currPos]);
                                    pointer++;*/
                                    //Console.WriteLine("suggestLD1-->{0}", word);
                                    WordSegmentEntry ws1 = new WordSegmentEntry();

                                    ws1.text = word;
                                    ws1.length = word.Length;
                                    // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                    //chkSound = suggestWords.Length;
                                    list.Add(ws1);
                                    pointer++;
                                    i += 10;
                                }

                                else if (LDSuggestWord.GetSuggestLDWords(wordChk).Count() > 0)
                                {
                                    WordSegmentEntry ws1 = new WordSegmentEntry();

                                    ws1.text = wordChk;
                                    ws1.length = wordChk.Length;
                                    // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                    //chkSound = suggestWords.Length;
                                    list.Add(ws1);
                                    pointer++;
                                    i += 10;
                                    //    currentSeg[currPos].text = wordChk;
                                    //   currentSeg[currPos].length = wordChk.Length;
                                    //  list.Add(currentSeg[currPos]);
                                    // pointer++;
                                    currPos++;

                                }

                                //  }

                                //  suggestLD = LDSuggestWord.GetSuggestLDWords(word);


                            }
                            else
                            {
                                suggestLD = LDSuggestWord.GetSuggestWords(word);
                                if (suggestLD.Count() > 0)
                                {
                                    //   Console.WriteLine("wordsuggestLD2-->{0}", word);
                                    // /for (int cp = 0; cp < suggestLD.Count(); cp++)
                                    //    Console.WriteLine("suggestLD2-->{0}", suggestLD[cp].Text);
                                    /*  WordSegmentEntry ws1 = new WordSegmentEntry();

                                      ws1.text = word;
                                      ws1.length = word.Length;
                                      // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                      //chkSound = suggestWords.Length;
                                      list.Add(ws1);
                                      pointer++;
                                      i += 10;*/

                                    string wordChk = "";
                                    try
                                    {
                                        if ((!Regex.IsMatch(currentSeg[currPos + 1].text, " ")))
                                            wordChk = word + currentSeg[currPos + 1].text;

                                        else
                                            wordChk = word;
                                        Console.WriteLine("suggestChk1-->{0}", wordChk);
                                    }
                                    catch (System.IndexOutOfRangeException e)  // CS0168
                                    {
                                        //System.Console.WriteLine(e.Message);
                                        wordChk = word;
                                        //set IndexOutOfRangeException to the new exception's InnerException
                                        //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                    }

                                    //  suggestLD = LDSuggestWord.GetSuggestLDWords(wordChk);
                                    if (LDSuggestWord.GetSuggestLDWords(wordChk).Count() == 0)
                                    {
                                        /*currentSeg[currPos].text = word;
                                        currentSeg[currPos].length = word.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;*/
                                        //  Console.WriteLine("suggestWord.Length-->{0}--i-->{1}", suggestWord.Length, i);
                                      /*    if ((suggestWord.Length - i) <= 5)*/
                                        //  {
                                              WordSegmentEntry ws1 = new WordSegmentEntry();

                                              ws1.text = word;
                                              ws1.length = word.Length;
                                              // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                              //chkSound = suggestWords.Length;
                                              list.Add(ws1);
                                              pointer++;
                                              i += 10;
                                        //  }
                                          //else {
                                            /*  WordSegmentEntry ws1 = new WordSegmentEntry();

                                              ws1.text = suggestWord[i];
                                              ws1.length = suggestWord[i].Length;
                                              // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                              //chkSound = suggestWords.Length;
                                              list.Add(ws1);
                                              pointer++;
                                          */
                                         // }
                                    }

                                    else if (LDSuggestWord.GetSuggestLDWords(wordChk).Count() > 0)
                                    {
                                        WordSegmentEntry ws1 = new WordSegmentEntry();

                                        ws1.text = wordChk;
                                        ws1.length = wordChk.Length;
                                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                        //chkSound = suggestWords.Length;
                                        list.Add(ws1);
                                        pointer++;
                                        i += 10;
                                        //    currentSeg[currPos].text = wordChk;
                                        //   currentSeg[currPos].length = wordChk.Length;
                                        //  list.Add(currentSeg[currPos]);
                                        // pointer++;
                                        currPos++;
                                        index++;
                                    }

                                    /*  }
                                      catch (System.IndexOutOfRangeException e)  // CS0168
                                      {
                                          System.Console.WriteLine(e.Message);
                                          //set IndexOutOfRangeException to the new exception's InnerException
                                          //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                      }*/
                                    //  suggestLD = LDSuggestWord.GetSuggestLDWords(word);
                                }
                                else
                                {
                                     Console.WriteLine("mix1-->{0}", list[pointer - 1].text);
                                     Console.WriteLine("mix2-->{0}", suggestWord[i]);
                                    if (i == 0)
                                    {
                                        WordSegmentEntry ws1 = new WordSegmentEntry();

                                        ws1.text = suggestWord[i];
                                        ws1.length = suggestWord[i].Length;
                                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                        //chkSound = suggestWords.Length;
                                        list.Add(ws1);
                                        pointer++;
                                    }
                                    else
                                    {
                                        list[pointer - 1].text += suggestWord[i];
                                        list[pointer - 1].length += suggestWord[i].Length;
                                    }
                                }

                            }
                        }

                        else
                        {

                            // add word
                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = word;
                            ws1.length = word.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                            i += 10;
                        }
                     //   }//new
                     //   else
                     /*   {

                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = suggestWord[i];
                            ws1.length = suggestWord[i].Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                        }*/
                }
                    
                }

            }
            else
            {

                //Console.WriteLine("length -->2");

                String chk = suggestWord[0] + suggestWord[1];
                suggestLD = LDSuggestWord.GetSuggestLDWords(chk);
                if (suggestLD.Count() > 0)
                {
                    WordSegmentEntry ws1 = new WordSegmentEntry();

                    ws1.text = chk;
                    ws1.length = chk.Length;
                    // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                    //chkSound = suggestWords.Length;
                    list.Add(ws1);
                    pointer++;

                }

                else if (suggestLD.Count() <= 0)
                {
                    suggestLD = LDSuggestWord.GetSuggestWords(chk);
                    if (suggestLD.Count() > 0)
                    {
                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = chk;
                        ws1.length = chk.Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;
                    }
                    else if (suggestLD.Count() <= 0)
                    {

                        for (int i = 0; i < 2; i++)
                        {
                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = suggestWord[i];
                            ws1.length = suggestWord[i].Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;

                        }

                    }
                }
            }

        }


        public void cleanTrueText()
        {
            string word = "";
            int chkSound = 0;
            int chk = 0;
            for (int i = 0; i < suggestWord.Length; i++)
            {


                Console.WriteLine("suggestWord-->{0} i-->{1}", suggestWord[i],i);
                word = "";
                if (i == 0)
                {


                    string wordChk = "";
                    try
                    {
                        if ((!Regex.IsMatch(suggestWord[i], " ")))
                            // Console.WriteLine("currentSeg[currPos - 1].text-->{0}", currentSeg[currPos - 1].text);
                            wordChk = currentSeg[currPos - 1].text + suggestWord[i];
                        else
                        {
                            /*WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = suggestWord[i];
                            ws1.length = suggestWord[i].Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;*/
                            chk = 1;
                        
                        }
                       //     wordChk = currentSeg[currPos - 1].text;
                        Console.WriteLine("wordChk-->{0}", wordChk);
                    }
                    catch (System.IndexOutOfRangeException e)  // CS0168
                    {
                        //System.Console.WriteLine(e.Message);
                        try
                        {
                            wordChk = suggestWord[i] + suggestWord[i + 1];
                        }
                        catch (System.IndexOutOfRangeException ex)  // CS0168
                        {
                            wordChk = suggestWord[i];

                        }
                        //set IndexOutOfRangeException to the new exception's InnerException
                        //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                    }


                    chkSound = checkSoundex(wordChk);

                    if (chkSound == 0||chk==1)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = suggestWord[i];
                        ws1.length = suggestWord[i].Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;

                    }

                    else if (chkSound > 0)
                    {
                        list[pointer - 1].text = wordChk;
                        list[pointer - 1].length = wordChk.Length;
                    }

                }
                else if (i > 0 && i < (suggestWord.Length - 2))
                {

                    string wordChk = suggestWord[i] + suggestWord[i + 1];

                    chkSound = checkSoundex(wordChk);

                    if (chkSound == 0)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = suggestWord[i];
                        ws1.length = suggestWord[i].Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;

                    }

                    else if (chkSound > 0)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = wordChk;
                        ws1.length = wordChk.Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;
                        i++;

                    }


                }

                else if (i == (suggestWord.Length - 2))
                {

                    string wordChk = suggestWord[i] + suggestWord[i + 1];
                    string wordChk1 = "";
                    chkSound = checkSoundex(wordChk);

                    if (chkSound == 0)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = suggestWord[i];
                        ws1.length = suggestWord[i].Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;

                    }

                    else if (chkSound > 0)
                    {


                        try
                        {
                            wordChk1 = wordChk + currentSeg[currPos + 1].text;
                            //   Console.WriteLine("suggestChk1-->{0}", suggestChk);
                        }
                        catch (System.IndexOutOfRangeException e)  // CS0168
                        {
                            //System.Console.WriteLine(e.Message);
                            wordChk1 = wordChk;
                            //set IndexOutOfRangeException to the new exception's InnerException
                            //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                        }

                        if (checkSoundex(wordChk1) == 0)
                        {

                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = wordChk;
                            ws1.length = wordChk.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                            i++;

                        }
                        else if (checkSoundex(wordChk1) > 0)
                        {


                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = wordChk1;
                            ws1.length = wordChk1.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                            i++;
                            currPos++;
                            index++;
                            i += 10;
                        }


                    }

                }

                else
                {
                    string wordChk = suggestWord[i];
                    string wordChk1 = "";
                    try
                    {
                        if ((!Regex.IsMatch(currentSeg[currPos].text, " ")))
                            wordChk1 = wordChk + currentSeg[currPos + 1].text;
                        else
                        {
                            wordChk1 = wordChk;
                        }
                         Console.WriteLine("wordChk1-->{0}", wordChk1);
                    }
                    catch (System.IndexOutOfRangeException e)  // CS0168
                    {
                        //System.Console.WriteLine(e.Message);
                        wordChk1 = wordChk;
                        //set IndexOutOfRangeException to the new exception's InnerException
                        //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                    }

                    if (checkSoundex(wordChk1) == 0)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = wordChk;
                        ws1.length = wordChk.Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;
                        i++;

                    }
                    else if (checkSoundex(wordChk1) > 0)
                    {


                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = wordChk;
                        ws1.length = wordChk.Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;
                        i++;
                        /* if ((!Regex.IsMatch(currentSeg[currPos].text, " ")))
                             currPos++;
                         else {
                            // wordChk1 = wordChk;
                         }*/
                        // currPos++;
                        index++;
                        i += 10;
                    }

                }




            }




        }


        public string segmentOpterated()
        {

            string ret = "";
           // UserDict userDict = Program.AuthUser.UserDict;
            SpellChkLib spellChkLib = NectecAPI.Instance.SpellCheck;
            SpellCheckerIgnore ignoreList = checker.IgnoreList;
            //  checkSoundex("ปลาตา");
            //  foreach (WordSegmentEntry ws in currentSeg)
            for (currPos = 0; currPos < currentSeg.Length; currPos++)
            {
                //  string selectText = ws.text;  old
                string selectText = currentSeg[currPos].text;
                 Console.WriteLine("selectText-->{0}", currentSeg[currPos].text);
                //  if ((!Regex.IsMatch(ws.text, "^[a-zA-Z]*$")) && (ws.IsThaiWord()))-->old
                if ((!Regex.IsMatch(currentSeg[currPos].text, "^[a-zA-Z]*$")) && (currentSeg[currPos].IsThaiWord()))
                {

                    //-->old        if ((!ignoreList.Exist(selectText, ws.start)) && (!userDict.Exist(ws.text.Trim())) && (!spellChkLib.DictCheck(ws.text.Trim())))
                    if ((!ignoreList.Exist(selectText, currentSeg[currPos].start)) && (!spellChkLib.DictCheck(currentSeg[currPos].text)))
                    {
                        // Console.WriteLine("word-->{0}", currentSeg[currPos].text);
                        if (index == 0)
                        {
                            //---> old      string word = ws.text;
                            string word = currentSeg[currPos].text;
                            int chkSound = checkSoundex(word);
                            // Console.WriteLine("soundex-->{0}", word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");


                                reSuggess(word, index);
                                /* try
                                 {
                                    string suggestChk = currentSeg[currPos].text + currentSeg[currPos + 1].text;
                                     //  Console.WriteLine("suggestChk2-->{0}", suggestChk);
                                    int chkSound1 = checkSoundex(suggestChk);
                                     if (chkSound1 == 0)
                                     {
                                         reSuggess(word, index);
                                     }

                                     else if (chkSound1 > 0)
                                     {


                                         currentSeg[currPos].text = suggestChk;
                                         currentSeg[currPos].length = suggestChk.Length;
                                         list.Add(currentSeg[currPos]);
                                         pointer++;
                                         currPos += 2;
                                     }

                                 }
                                 catch (System.IndexOutOfRangeException e)  // CS0168
                                 {
                                     System.Console.WriteLine(e.Message);
                                     //set IndexOutOfRangeException to the new exception's InnerException
                                     //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                 }*/

                            }
                            else if (chkSound > 0)
                            {
                                /* 
                                    currentSeg[currPos].text = word;
                                    currentSeg[currPos].length = word.Length;
                                    list.Add(currentSeg[currPos]);
                                    pointer++;*/

                                try
                                {
                                    string suggestChk = currentSeg[currPos].text + currentSeg[currPos + 1].text;
                                       Console.WriteLine("suggestChk1-->{0}", suggestChk);

                                    int chkSound1 = checkSoundex(suggestChk);
                                    if (chkSound1 == 0)
                                    {
                                        currentSeg[currPos].text = word;
                                        currentSeg[currPos].length = word.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;
                                    }

                                    else if (chkSound1 > 0)
                                    {
                                        currentSeg[currPos].text = suggestChk;
                                        currentSeg[currPos].length = suggestChk.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;
                                        currPos++;

                                    }

                                }
                                catch (System.IndexOutOfRangeException e)  // CS0168
                                {
                                    System.Console.WriteLine(e.Message);
                                    //set IndexOutOfRangeException to the new exception's InnerException
                                    //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                }
                            }
                            else
                            {

                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }

                        }
                        else if (index > 0)
                        {


                            string word = currentSeg[currPos].text;
                            //  Console.WriteLine("soundex2-->{0}", word);
                            //   Console.WriteLine("word-->{0}",word);
                            int chkSound = checkSoundex(word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");
                                // reSuggess(word, index);
                                if (index > 0)
                                {

                                    string suggestChk = currentSeg[currPos - 1].text + word;
                                       Console.WriteLine("worder-->{0}", suggestChk);
                                    chkSound = checkSoundex(suggestChk);
                                    //  chkSound = suggestWords.Length;
                                       Console.WriteLine("chksound-->{0}", suggestChk);


                                    if (chkSound > 0)
                                    {
                                        list[pointer - 1].text = suggestChk;
                                        list[pointer - 1].length = suggestChk.Length;
                                        // pointer++;
                                    }

                                    else if (chkSound == 0)
                                    {
                                        Console.WriteLine("word-->{0}", word);


                                        reSuggess(word, index);
                                        /*

                                        try
                                        {
                                            suggestChk = currentSeg[currPos].text + currentSeg[currPos + 1].text;
                                            //  Console.WriteLine("suggestChk2-->{0}", suggestChk);
                                            int chkSound1 = checkSoundex(suggestChk);
                                            if (chkSound1 == 0)
                                            {
                                                reSuggess(word, index);
                                            }

                                            else if (chkSound1 > 0)
                                            {
                                                currentSeg[currPos].text = suggestChk;
                                                currentSeg[currPos].length = suggestChk.Length;
                                                list.Add(currentSeg[currPos]);
                                                pointer++;
                                                currPos += 2;
                                            }

                                        }
                                        catch (System.IndexOutOfRangeException e)  // CS0168
                                        {
                                            System.Console.WriteLine(e.Message);
                                            //set IndexOutOfRangeException to the new exception's InnerException
                                            //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                        }*/
                                    }

                                }
                                else
                                {
                                    reSuggess(word, index);
                                }

                            }
                            else if (chkSound > 0)
                            {

                                /* currentSeg[currPos].text = word;
                                  currentSeg[currPos].length = word.Length;
                                  list.Add(currentSeg[currPos]);
                                  pointer++;*/
                                //  Console.WriteLine(" currentSeg[currPos - 1].text-->{0}", currentSeg[currPos - 1].text);
                                string suggestChk = currentSeg[currPos - 1].text + currentSeg[currPos].text;
                                //  Console.WriteLine("suggestChk3-->{0}", suggestChk);
                                int chkSound1 = checkSoundex(suggestChk);
                                if (chkSound1 == 0)
                                {
                                    /*  aaa  currentSeg[currPos].text = word;
                                        currentSeg[currPos].length = word.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;*/

                                    suggestLD = LDSuggestWord.GetSuggestLDWords(suggestChk);
                                    if (suggestLD.Count() > 0)
                                    {
                                        // for (int cp = 0; cp < suggestLD.Count(); cp++)
                                        //     Console.WriteLine("suggestLD1-->{0}", suggestLD[cp].Text);
                                        currentSeg[currPos - 1].text = suggestChk;
                                        currentSeg[currPos - 1].length = suggestChk.Length;
                                        //  list.Add(currentSeg[currPos]);
                                        //  pointer++;

                                    }

                                    else if (suggestLD.Count() == 0)
                                    {



                                        //  if (LDSuggestWord.GetSuggestWords(suggestChk).Count() == 0)
                                        //  {
                                        /*   currentSeg[currPos].text = word;
                                           currentSeg[currPos].length = word.Length;
                                           list.Add(currentSeg[currPos]);
                                           pointer++;*/
                                        // }

                                        // else if (LDSuggestWord.GetSuggestWords(suggestChk).Count() > 0)
                                        // {
                                        //     currentSeg[currPos-1].text = suggestChk;
                                        //     currentSeg[currPos-1].length = suggestChk.Length;
                                        //   list.Add(currentSeg[currPos]);
                                        //   pointer++;
                                        //  }

                                        try
                                        {
                                            if (!Regex.IsMatch(currentSeg[currPos + 1].text, " "))
                                            {
                                                suggestChk = currentSeg[currPos].text + currentSeg[currPos + 1].text;
                                                // Console.WriteLine("suggestChk2-->{0}", suggestChk);
                                                chkSound1 = checkSoundex(suggestChk);
                                                if (chkSound1 == 0)
                                                {
                                                    currentSeg[currPos].text = word;
                                                    currentSeg[currPos].length = word.Length;
                                                    list.Add(currentSeg[currPos]);
                                                    pointer++;
                                                }

                                                else if (chkSound1 > 0)
                                                {
                                                    currentSeg[currPos].text = suggestChk;
                                                    currentSeg[currPos].length = suggestChk.Length;
                                                    list.Add(currentSeg[currPos]);
                                                    pointer++;
                                                    currPos++;
                                                }
                                            }
                                            else
                                            {
                                                currentSeg[currPos].text = word;
                                                currentSeg[currPos].length = word.Length;
                                                list.Add(currentSeg[currPos]);
                                                pointer++;
                                                /*   suggestChk = currentSeg[currPos - 1].text + currentSeg[currPos].text;
                                                  Console.WriteLine("suggestChk3-->{0}", suggestChk);
                                                   chkSound1 = checkSoundex(suggestChk);
                                                  if (chkSound1 == 0)
                                                  {
                                                      /*  aaa  currentSeg[currPos].text = word;
                                                          currentSeg[currPos].length = word.Length;
                                                          list.Add(currentSeg[currPos]);
                                                          pointer++;*/

                                                /*   suggestLD = LDSuggestWord.GetSuggestLDWords(suggestChk);
                                                   if (suggestLD.Count() > 0)
                                                   {
                                                       // for (int cp = 0; cp < suggestLD.Count(); cp++)
                                                       //     Console.WriteLine("suggestLD1-->{0}", suggestLD[cp].Text);
                                                       currentSeg[currPos - 1].text = suggestChk;
                                                       currentSeg[currPos - 1].length = suggestChk.Length;
                                                       //  list.Add(currentSeg[currPos]);
                                                       //  pointer++;

                                                   }

                                                   else if (suggestLD.Count() == 0)
                                                   {



                                                       //  if (LDSuggestWord.GetSuggestWords(suggestChk).Count() == 0)
                                                       //  {
                                                       currentSeg[currPos].text = word;
                                                       currentSeg[currPos].length = word.Length;
                                                       list.Add(currentSeg[currPos]);
                                                       pointer++;
                                                       // }

                                                       // else if (LDSuggestWord.GetSuggestWords(suggestChk).Count() > 0)
                                                       // {
                                                       //     currentSeg[currPos-1].text = suggestChk;
                                                       //     currentSeg[currPos-1].length = suggestChk.Length;
                                                       //   list.Add(currentSeg[currPos]);
                                                       //   pointer++;
                                                       //  }

                                                   }

                                               }

                                               else if (chkSound1 > 0)
                                               {
                                                   currentSeg[currPos - 1].text = suggestChk;
                                                   currentSeg[currPos - 1].length = suggestChk.Length;
                                                   //     list.Add(currentSeg[currPos]);
                                                   //   //   pointer++;
                                                   //     currPos++;
                                               }
                                          */
                                            }


                                        }
                                        catch (System.IndexOutOfRangeException e)  // CS0168
                                        {
                                            // System.Console.WriteLine(e.Message);
                                            //set IndexOutOfRangeException to the new exception's InnerException
                                            //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                            /*   string suggestChk = currentSeg[currPos].text ;
                                               Console.WriteLine("suggestChk2.1-->{0}", suggestChk);
                                               int chkSound1 = checkSoundex(suggestChk);
                                               if (chkSound1 == 0)
                                               {*/
                                            currentSeg[currPos].text = word;
                                            currentSeg[currPos].length = word.Length;
                                            list.Add(currentSeg[currPos]);
                                            pointer++;

                                            /*   suggestChk = currentSeg[currPos - 1].text + currentSeg[currPos].text;
                                              Console.WriteLine("suggestChk3-->{0}", suggestChk);
                                              chkSound1 = checkSoundex(suggestChk);
                                              if (chkSound1 == 0)
                                              {
                                                  currentSeg[currPos].text = word;
                                                  currentSeg[currPos].length = word.Length;
                                                  list.Add(currentSeg[currPos]);
                                                  pointer++;
                                              }

                                              else if (chkSound1 > 0)
                                              {
                                                  currentSeg[currPos - 1].text = suggestChk;
                                                  currentSeg[currPos - 1].length = suggestChk.Length;
                                                  // list.Add(currentSeg[currPos]);
                                                  //pointer++;
                                                  //  currPos++;
                                              }

                                              /*  }

                                                else if (chkSound1 > 0)
                                                {
                                                    currentSeg[currPos].text = suggestChk;
                                                    currentSeg[currPos].length = suggestChk.Length;
                                                    list.Add(currentSeg[currPos]);
                                                    pointer++;
                                                    currPos++;
                                                }*/
                                        }

                                    }

                                }

                                else if (chkSound1 > 0)
                                {
                                    currentSeg[currPos].text = suggestChk;
                                    currentSeg[currPos].length = suggestChk.Length;

                                 //    Console.WriteLine(" currentSeg[currPos - 1].text-->{0}", currentSeg[currPos - 1].text);
                                    //     list.Add(currentSeg[currPos]);
                                    //  pointer++;
                                    list[pointer - 1].text = suggestChk;
                                    list[pointer - 1].length = suggestChk.Length;
                                    //     currPos++;
                                }





                            }
                            else
                            {


                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);

                                pointer++;
                            }


                        }


                    }

                    else
                    {


                        currentSeg[currPos].text = selectText;
                        currentSeg[currPos].length = selectText.Length;
                        list.Add(currentSeg[currPos]);
                        pointer++;

                        // Console.WriteLine("sel-->{0}", selectText);
                        // sfsdfsdf
                      /*  string chkEnd = "";
                        try
                        {
                            if ((!Regex.IsMatch(currentSeg[currPos + 1].text, " ")))
                                chkEnd = selectText + currentSeg[currPos + 1].text;
                            else
                            {
                                chkEnd = selectText;
                            }
                            // Console.WriteLine("wordChk1-->{0}", wordChk1);
                        }
                        catch (System.IndexOutOfRangeException e)  // CS0168
                        {
                            //System.Console.WriteLine(e.Message);
                            chkEnd = selectText;
                            //set IndexOutOfRangeException to the new exception's InnerException
                            //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                        }

                     

                        if (checkSoundex(chkEnd) == 0)
                        {

                           //  suggestLD = LDSuggestWord.GetSuggestLDWords(chkEnd);
                           /*  d       if (LDSuggestWord.GetSuggestLDWords(chkEnd).Count() > 0)
                                    {
                                        Console.WriteLine("chkEnd-->{0}", chkEnd);
                                        // for (int cp = 0; cp < suggestLD.Count(); cp++)
                                        //     Console.WriteLine("suggestLD1-->{0}", suggestLD[cp].Text);
                                       // currentSeg[currPos - 1].text = suggestChk;
                                       // currentSeg[currPos - 1].length = suggestChk.Length;
                                        //  list.Add(currentSeg[currPos]);
                                        //  pointer++;
                                          WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = chkEnd;
                            ws1.length = chkEnd.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                            currPos++;

                                    }

                                    else if (LDSuggestWord.GetSuggestLDWords(chkEnd).Count() == 0)
                                    {


                                        currentSeg[currPos].text = selectText;
                                        currentSeg[currPos].length = selectText.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;
                                    }*/
                            // old
                         /*    currentSeg[currPos].text = selectText;
                                        currentSeg[currPos].length = selectText.Length;
                                        list.Add(currentSeg[currPos]);
                                        pointer++;
                             
                             

                        }
                        else if (checkSoundex(chkEnd) > 0)
                        {

                            WordSegmentEntry ws1 = new WordSegmentEntry();

                            ws1.text = chkEnd;
                            ws1.length = chkEnd.Length;
                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                            //chkSound = suggestWords.Length;
                            list.Add(ws1);
                            pointer++;
                            currPos++;
                            //  i++;

                        }

*/
                    }

                    // Console.WriteLine("text-->{0}", ws.text);
                    //           Console.WriteLine("{0}", selectText);
                }
                else
                {

                    // Console.WriteLine("sel-->{0}", selectText);
                 /*  // sfsdfsdf
                    string chkEnd = "";
                     try
                    {
                        if ((!Regex.IsMatch(currentSeg[currPos+1].text, " ")))
                            chkEnd = selectText + currentSeg[currPos + 1].text;
                        else
                        {
                            chkEnd = selectText;
                        }
                        // Console.WriteLine("wordChk1-->{0}", wordChk1);
                    }
                    catch (System.IndexOutOfRangeException e)  // CS0168
                    {
                        //System.Console.WriteLine(e.Message);
                        chkEnd = selectText;
                        //set IndexOutOfRangeException to the new exception's InnerException
                        //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                    }

                     Console.WriteLine("chkEnd-->{0}", chkEnd);

                     if (checkSoundex(chkEnd) == 0)
                    {

                        currentSeg[currPos].text = selectText;
                        currentSeg[currPos].length = selectText.Length;
                        list.Add(currentSeg[currPos]);
                        pointer++;

                       

                    }
                     else if (checkSoundex(chkEnd) > 0)
                    {

                        WordSegmentEntry ws1 = new WordSegmentEntry();

                        ws1.text = chkEnd;
                        ws1.length = chkEnd.Length;
                        // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                        //chkSound = suggestWords.Length;
                        list.Add(ws1);
                        pointer++;
                        currPos++;
                      //  i++;
                    
                    }*/
                    currentSeg[currPos].text = selectText;
                    currentSeg[currPos].length = selectText.Length;
                    list.Add(currentSeg[currPos]);
                    pointer++;
                }
                index++;
            }


            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine("{0}", list[i].text);
                // if(i<list.Count-1)
                if (i == 0)
                    ret += "|" + list[i].text + "|";
                else
                    ret += list[i].text + "|";
                //  else if (i == list.Count - 1)
                //   ret += list[i].text ;
            }
            return ret.ToString();
        }


        public string segmentSpace()
        {

            string ret = "";
           // UserDict userDict = Program.AuthUser.UserDict;
            SpellChkLib spellChkLib = NectecAPI.Instance.SpellCheck;
            SpellCheckerIgnore ignoreList = checker.IgnoreList;
            //  checkSoundex("ปลาตา");
            //  foreach (WordSegmentEntry ws in currentSeg)
            for (currPos = 0; currPos < currentSeg.Length; currPos++)
            {
                //  string selectText = ws.text;  old
                string selectText = currentSeg[currPos].text;
                //Console.WriteLine("{0}", currentSeg[currPos].text);
                //  if ((!Regex.IsMatch(ws.text, "^[a-zA-Z]*$")) && (ws.IsThaiWord()))-->old
                if ((!Regex.IsMatch(currentSeg[currPos].text, "^[a-zA-Z]*$")) && (currentSeg[currPos].IsThaiWord()))
                {





                    //-->old        if ((!ignoreList.Exist(selectText, ws.start)) && (!userDict.Exist(ws.text.Trim())) && (!spellChkLib.DictCheck(ws.text.Trim())))
                    if ((!ignoreList.Exist(selectText, currentSeg[currPos].start))  && (!spellChkLib.DictCheck(currentSeg[currPos].text)))
                    {

                        if (index == 0)
                        {
                            //---> old      string word = ws.text;
                            string word = currentSeg[currPos].text;
                            int chkSound = checkSoundex(word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");


                                reSuggess(word, index);


                            }
                            else if (chkSound == 1)
                            {

                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }
                            else
                            {



                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }

                        }
                        else if (index > 0)
                        {


                            string word = currentSeg[currPos].text;

                            //Console.WriteLine("word-->{0}",word);
                            int chkSound = checkSoundex(word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");
                                // reSuggess(word, index);
                                if (index > 0)
                                {

                                    string suggestChk = currentSeg[currPos - 1].text + word;
                                    chkSound = checkSoundex(suggestChk);
                                    //  chkSound = suggestWords.Length;
                                    //   Console.WriteLine("chksound-->{0}", suggestChk);


                                    if (chkSound > 0)
                                    {
                                        list[pointer - 1].text = suggestChk;
                                        list[pointer - 1].length = suggestChk.Length;
                                        // pointer++;
                                    }

                                    else if (chkSound == 0)
                                    {
                                        //  Console.WriteLine("word-->{0}", word);
                                        reSuggess(word, index);
                                    }

                                }
                                else
                                {
                                    reSuggess(word, index);
                                }

                            }
                            else if (chkSound == 1)
                            {

                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }
                            else
                            {


                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);

                                pointer++;
                            }


                        }


                    }

                    else
                    {


                        currentSeg[currPos].text = selectText;
                        currentSeg[currPos].length = selectText.Length;
                        list.Add(currentSeg[currPos]);
                        pointer++;
                    }

                    // Console.WriteLine("text-->{0}", ws.text);
                    //           Console.WriteLine("{0}", selectText);
                }
                else
                {


                    currentSeg[currPos].text = selectText;
                    currentSeg[currPos].length = selectText.Length;
                    list.Add(currentSeg[currPos]);
                    pointer++;
                }
                index++;
            }


            for (int i = 0; i < list.Count; i++)
            {

                //Console.WriteLine("{0}", list[i].text);
                // if(i<list.Count-1)
                if (i == 0)
                    ret += " " + list[i].text + " ";
                else
                    ret += list[i].text + " ";
                //  else if (i == list.Count - 1)
                //   ret += list[i].text ;
            }
            return ret.ToString();
        }


        public WordSegmentEntry[] segmentOpterate()
        {


           // UserDict userDict = Program.AuthUser.UserDict;
            SpellChkLib spellChkLib = NectecAPI.Instance.SpellCheck;
            SpellCheckerIgnore ignoreList = checker.IgnoreList;
            //  checkSoundex("ปลาตา");
            //  foreach (WordSegmentEntry ws in currentSeg)
            for (currPos = 0; currPos < currentSeg.Length; currPos++)
            {
                //  string selectText = ws.text;  old
                string selectText = currentSeg[currPos].text;
                //   Console.WriteLine("{0}", ws.text);
                //  if ((!Regex.IsMatch(ws.text, "^[a-zA-Z]*$")) && (ws.IsThaiWord()))-->old
                if ((!Regex.IsMatch(currentSeg[currPos].text, "^[a-zA-Z]*$")) && (currentSeg[currPos].IsThaiWord()))
                {





                    //-->old        if ((!ignoreList.Exist(selectText, ws.start)) && (!userDict.Exist(ws.text.Trim())) && (!spellChkLib.DictCheck(ws.text.Trim())))
                    if ((!ignoreList.Exist(selectText, currentSeg[currPos].start))  && (!spellChkLib.DictCheck(currentSeg[currPos].text)))
                    {

                        //                         int cp = 2;
                        /* if ((index - 2) >= 0)
                        {
                           
                            cp = string.Compare(seg[index - 1].text, spCharact);
                            if (cp == 1 || cp == -1)
                            {
                                cp = 2;
                                cp = string.Compare(seg[index - 2].text, spCharact);
                             
                        }}*/
                        //---------- check string --> "
                        // list.Add(ws.text.Trim());
                        //   checkSoundex("วิดทะยาสาด");
                        if (index == 0)
                        {
                            //---> old      string word = ws.text;
                            string word = currentSeg[currPos].text;
                            int chkSound = checkSoundex(word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");


                                reSuggess(word, index);


                            }
                            else if (chkSound == 1)
                            {
                                //  Console.WriteLine("soundex");
                                //--------  list.Add(ws.text.Trim());  old
                                /*   ws.text = word;
                                   ws.length = word.Length;-->  old
                                   list.Add(ws);*/

                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }
                            else
                            {

                                //    Console.WriteLine("more soundex");
                                //-----------    list.Add(ws.text.Trim());  old
                                /*  ws.text = word;
                                  ws.length = word.Length;
                                  list.Add(ws);--->  Old*/


                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }
                            /*  // int offset = this.Paragraph.Range.Start.ToInt();
                              string g2p = wseg.GetG2P(word);

                              string[] soudexs = homo.Homophone(word, g2p).ToArray();
                              Console.WriteLine("selectText-->{0}", selectText);
                              Console.WriteLine("g2p-->{0}", g2p.ToString());
                              foreach (var s in soudexs)
                              {
                                  //logger.Debug("soundex: "+s);
                                  if (suggests.Count < 100)
                                  {
                                      SpellWordSuggestEntry ws1 = new SpellWordSuggestEntry();
                                      ws1.Text = s;
                                      ws1.Type = SuggestType.Soundex;
                                      Console.WriteLine("sound-->{0}", s.ToString());
                                      //  suggests.Add(ws);
                                  }
                                  else
                                  {
                                      break;
                                  }
                              }*/
                        }
                        else if (index > 0)
                        {
                            // string sign=@""";

                            /* if (cp==0)//---------check special Text-->"
                             { 
                             
                             //check special char-->"
                                 string word = ws.text;
                                 int chkSound = checkSoundex(word);
                                 if (chkSound == 0)
                                 {
                                     Console.WriteLine("not soundex");

                                 }
                                 else if (chkSound == 1)
                                 {
                                     Console.WriteLine("soundex");
                                 }
                                 else
                                 {

                                     Console.WriteLine("more soundex");
                                 }



                             }*/
                            /* else
                             {*/

                            //--> old    string word = ws.text;

                            string word = currentSeg[currPos].text;

                            //  Console.WriteLine("word-->{0}",word);
                            int chkSound = checkSoundex(word);
                            if (chkSound == 0)
                            {
                                // Console.WriteLine("not soundex");
                                // reSuggess(word, index);
                                if (index > 0)
                                {

                                    string suggestChk = currentSeg[currPos - 1].text + word;
                                    chkSound = checkSoundex(suggestChk);
                                    //  chkSound = suggestWords.Length;
                                    //   Console.WriteLine("chksound-->{0}", suggestChk);


                                    if (chkSound > 0)
                                    {
                                        list[pointer - 1].text = suggestChk;
                                        list[pointer - 1].length = suggestChk.Length;
                                        // pointer++;
                                    }

                                    else if (chkSound == 0)
                                    {

                                        reSuggess(word, index);
                                    }

                                }
                                else
                                {
                                    reSuggess(word, index);
                                }

                            }
                            else if (chkSound == 1)
                            {
                                //   Console.WriteLine("soundex");
                                /*   ws.text = word;
                                   ws.length = word.Length;
                                   list.Add(ws);*/
                                //-->old 
                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);
                                pointer++;
                            }
                            else
                            {

                                //  Console.WriteLine("more soundex");
                                /*  ws.text = word;
                                  ws.length = word.Length;
                                  list.Add(ws);--> old   */
                                currentSeg[currPos].text = word;
                                currentSeg[currPos].length = word.Length;
                                list.Add(currentSeg[currPos]);

                                pointer++;
                            }
                            // int offset = this.Paragraph.Range.Start.ToInt();
                            /*   string g2p = wseg.GetG2P(word);

                               string[] soudexs = homo.Homophone(word, g2p).ToArray();
                               Console.WriteLine("selectText-->{0}", selectText);
                               Console.WriteLine("g2p-->{0}", g2p.ToString());
                               foreach (var s in soudexs)
                               {
                                   //logger.Debug("soundex: "+s);
                                   if (suggests.Count < 100)
                                   {
                                       SpellWordSuggestEntry ws1 = new SpellWordSuggestEntry();
                                       ws1.Text = s;
                                       ws1.Type = SuggestType.Soundex;
                                       Console.WriteLine("sound-->{0}", s.ToString());
                                       //  suggests.Add(ws);
                                   }
                                   else
                                   {
                                       break;
                                   }
                               }*/
                            /*   }*/
                            //----------------end check special Text



                            //  Console.WriteLine("seg-->{0}--index-->{1}", seg[index-1].text, index);
                            // Console.WriteLine("spCharact-->{0}", spCharact);
                            //   Console.WriteLine("cp-->{0}",cp);
                            //  Console.WriteLine("segDec-->{0}", (ConvertStringDecimal(seg[index - 1].text)));
                            //       if (((ConvertStringDecimal(seg[index - 1].text)) == 34) || ((ConvertStringDecimal(seg[index - 2].text)) == 34))
                            //  {

                            //  Console.WriteLine("text-->compare");

                            //   }

                        }

                        /*    suggestWords = LDSuggestWord.GetSuggestWords(selectText);//-----word search-----
                            LongLexTo.spellChkWordUTF(ws.text.Trim());
                            String firstLine = streamFile("data.txt");*/
                        //  Console.WriteLine("seg-->{0}", seg[index].text);
                        //  Console.WriteLine("{0}", firstLine);
                    }

                    else
                    {

                        /*   LongLexTo.spellChkWordUTF(ws.text.Trim());
                           String firstLine = streamFile("data.txt");
                         //  Console.WriteLine("seg-->{0}", seg[index].text);
                           Console.WriteLine("{0}",firstLine);*/
                        //list.Add(ws.text.Trim());--------------old
                        /*  ws.text = selectText;
                          ws.length = selectText.Length;
                          list.Add(ws);--> old */
                        currentSeg[currPos].text = selectText;
                        currentSeg[currPos].length = selectText.Length;
                        list.Add(currentSeg[currPos]);
                        pointer++;
                    }

                    // Console.WriteLine("text-->{0}", ws.text);
                    //           Console.WriteLine("{0}", selectText);
                }
                else
                {

                    /*   LongLexTo.spellChkWordUTF(ws.text.Trim());
                       String firstLine = streamFile("data.txt");
                     //  Console.WriteLine("seg-->{0}", seg[index].text);
                       Console.WriteLine("{0}",firstLine);*/
                    //list.Add(ws.text.Trim());--------------old
                    /*  ws.text = selectText;
                      ws.length = selectText.Length;
                      list.Add(ws);--> old--> */
                    currentSeg[currPos].text = selectText;
                    currentSeg[currPos].length = selectText.Length;
                    list.Add(currentSeg[currPos]);
                    pointer++;
                }
                index++;
            }

            //for (int i = 0; i < list.Count; i++)
            //{ Console.WriteLine("{0}", list[i]); }

            // Console.WriteLine("hello");
            for (int i = 0; i < list.Count; i++)
            {

                //   Console.WriteLine("{0}", list[i].text);

            }
            return list.ToArray();
        }

        public SegmentSolution(WordSegmentEntry[] seg, LDSpellChecker checker)
        {
            //     string spCharact = "\"";//--> special text-->"
            //    HomophoneLib homo = NectecAPI.Instance.HomoPhone;
            //    LDWordSegment wseg = new LDWordSegment();
            //      List<SpellWordSuggestEntry> suggests = new List<SpellWordSuggestEntry>();
            // this.parent = parent;
            //    MisSpellingEntry entry = new MisSpellingEntry(parent, iMisSpellls.Count, selectText, ws.startNonLF);
            currentSeg = new WordSegmentEntry[seg.Length];
            Array.Copy(seg, currentSeg, seg.Length);
            //SpellCheckerIgnore ignoreList = iSpellChecker.IgnoreList;
            //Console.WriteLine("Text-->{0}", wseg.GetG2P(selectText));
            this.checker = checker;
            list.Clear();

            index = 0;
            pointer = 0;
            //  MessageBox.Show("after-->",
            //  "xxx");
            //-----------end  set up data---------------------------------

        }

        public void reSuggess(string selectText, int index)
        {

            //  suggestWords = LDSuggestWord.GetSuggestWords(selectText.Trim());//-----word search-----
            // Console.WriteLine("selectText");
            int chkStart = 0;
            if (selectText.Length > 3)
            {

                //  Console.WriteLine("selectText-->{0}", selectText);
                string ret = LongLexTo.spellChkWordString(selectText);
                  Console.WriteLine("string ret-->{0}", ret);
                //  LongLexTo.spellChkWordUTF(selectText );
                //String firstLine = streamFile("data.txt");
                splitData(ret);


                int chkZero = checkWrong();
                string suggest = "", suggestChk = "", suggestChkLast = "";
                int cLength = 0;
                int chkSound = 0;
                WordSegmentEntry ws = new WordSegmentEntry();
                // Console.WriteLine("index-->{0}=current{1}",index, currentSeg[index].text);
                if (chkZero == 0)
                {


                    //Console.WriteLine("zero");
                    if (suggestWord.Length >= 4)
                    {
                        cleanLongText();
                        /* for (int i = 0; i < suggestWord.Length; i++)
                         {

                             suggest += suggestWord[i];
                             cLength += suggestWord[i].Length;

                         }

                         ws.text = suggest;
                         ws.length = cLength;
                         list.Add(ws);
                         pointer++;
    */
                    }
                    /*    else if (suggestWord.Length <= 2) {
                       

                                for (int i = 0; i < suggestWord.Length; i++)
                                {

                                    WordSegmentEntry ws1 = new WordSegmentEntry();
                                    //   ws.text = suggestWord[i];
                                    //   ws.length = suggestWord[i].Length;x]
                                    //   Console.WriteLine("ws-->{0}", ws.text);
                                    ws1.text = suggestWord[i];
                                    ws1.length = suggestWord[i].Length;
                                    list.Add(ws1);
                                    //       list.
                                    pointer++;
                                }

                        
                    
                        }*/
                    else
                    {

                        if (string.Compare(status[0].ToString(), "0") == 0)
                        {

                            for (int i = 0; i < suggestWord.Length; i++)
                            {

                                suggest += suggestWord[i];
                                cLength += suggestWord[i].Length;

                            }
                            //     Console.WriteLine("suggest[0]-->{0}", suggest);
                            //   Console.WriteLine("suggest-->{0}",suggest); 
                            //-----------------------suggess-------------------------------
                            if (index == 0)
                            {
                                //suggestChk = suggest;

                                ws.text = suggest;
                                ws.length = cLength;
                                list.Add(ws);
                                pointer++;


                            }
                            else if (index > 0)
                            {
                                //  Console.WriteLine("suggest-->{0}", suggest); 
                                suggestChk = currentSeg[index - 1].text + suggest;
                                chkSound = checkSoundex(suggestChk);
                                //  chkSound = suggestWords.Length;
                                if (chkSound > 0)
                                {
                                    // list[pointer - 1].text = suggestChk;
                                    // list[pointer - 1].length = suggestChk.Length;

                                }

                                else if (chkSound == 0)
                                {

                                    ws.text = suggest;
                                    ws.length = cLength;
                                    list.Add(ws);
                                    pointer++;
                                    /*   for (int i = 0; i < suggestWord.Length; i++)
                                       {

                                           if (string.Compare(status[0].ToString(), "0") == 0)
                                           { 
                                      
                                    
                                           }
                                
                                       }*/

                                }
                            }


                        }

                        else if (string.Compare(status[status.Length - 1].ToString(), "0") == 0 && (suggestWord[status.Length - 1].Length == 1))
                        {
                            for (int i = 0; i < suggestWord.Length; i++)
                            {

                                suggest += suggestWord[i];
                                cLength += suggestWord[i].Length;

                            }

                            // Console.WriteLine("{0}", currentSeg[index].text);
                            //   if (currentSeg[index + 1].)
                            //if (String.IsNullOrEmpty(currentSeg[index + 1].text))
                            try
                            {
                                suggestChk = suggest + currentSeg[currPos + 1].text;

                                //  Console.WriteLine("suggestChk-->{0}", suggestChk);
                            }
                            catch (System.IndexOutOfRangeException e)  // CS0168
                            {
                                System.Console.WriteLine(e.Message);
                                //set IndexOutOfRangeException to the new exception's InnerException
                                //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                            }

                            suggestWords = LDSuggestWord.GetSuggestLDWords(suggestChk);
                            chkSound = suggestWords.Length;

                            if (chkSound > 0)
                            {
                                ws.text = suggestChk;
                                ws.length = suggestChk.Length;
                                list.Add(ws);
                                pointer++;
                                // index++;
                                index++;
                                currPos++;

                            }

                            else if (chkSound == 0)
                            {

                                ws.text = suggest;
                                ws.length = cLength;
                                list.Add(ws);
                                pointer++;

                            }

                        }
                        else
                        {
                            cleanLongText();

                            /*  for (int i = 0; i < suggestWord.Length; i++)
                              {

                                  suggest += suggestWord[i];
                                  cLength += suggestWord[i].Length;

                              }
                              ws.text = suggest;
                              ws.length = cLength;
                              list.Add(ws);
                              pointer++;//--------------old check Last*/

                            /* suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                             chkSound = suggestWords.Length;
                         //    Console.WriteLine("countLine-->{0}", chkSound);
                             if (chkSound == 0) 
                             {
                                 for (int i = 0; i < suggestWord.Length; i++)
                                 {

                                     if (string.Compare(status[i].ToString(), "0") == 0)
                                     {


                                         try
                                         {
                                            
                                             WordSegmentEntry ws1 = new WordSegmentEntry();

                                             ws1.text = suggestWord[i] + suggestWord[i+1];
                                             ws1.length = suggestWord[i].Length + suggestWord[i+1].Length;
                                            // suggestWords = LDSuggestWord.GetSuggestLDWords(suggest);
                                             //chkSound = suggestWords.Length;
                                             list.Add(ws1);
                                             pointer++;
                                             if ((i + 1) == suggestWord.Length-1)
                                             {
                                                 i += 10;
                                             }
                                            // index++;
                                           //  currPos++;i
                                         }
                                         catch (System.IndexOutOfRangeException e)  // CS0168
                                         {
                                             System.Console.WriteLine(e.Message);
                                             //set IndexOutOfRangeException to the new exception's InnerException
                                             //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                         }

                                      


                                     }
                                     else {
                                         WordSegmentEntry ws1 = new WordSegmentEntry();

                                         ws1.text = suggestWord[i];
                                         ws1.length = suggestWord[i].Length;
                                         list.Add(ws1);
                                         pointer++;
                                     }
                                 }

                             }

                             else if (chkSound > 0)
                             {

                                 ws.text = suggest;
                                 ws.length = cLength;
                                 list.Add(ws);
                                 pointer++;
                             }


                        */
                        }

                    }
                }
                else if (chkZero == 1)
                {
                    //Console.WriteLine("one");
                    //     WordSegmentEntry ws = new WordSegmentEntry();

                    if ((suggestWord.Length == 2) && (string.Compare(status[0].ToString(), "1") == 0) && (string.Compare(status[1].ToString(), "1") == 0))
                    {
                        /*  int chk = checkMostPriorty();
                       //   Console.WriteLine("sugg1-->{0} --- sugg2-->{1}", suggestWord[0] , suggestWord[1]);
                          if (chk == 1)
                          {

                              ws.text = suggestWord[0] + suggestWord[1];
                              ws.length = suggestWord[0].Length + suggestWord[1].Length;
                              list.Add(ws);
                              pointer++;
                          }

                          else {*/
                        for (int i = 0; i < suggestWord.Length; i++)
                        {

                            WordSegmentEntry ws1 = new WordSegmentEntry();
                            //   ws.text = suggestWord[i];
                            //   ws.length = suggestWord[i].Length;x]
                            //   Console.WriteLine("ws-->{0}", ws.text);
                            ws1.text = suggestWord[i];
                            ws1.length = suggestWord[i].Length;
                            list.Add(ws1);
                            //       list.
                            pointer++;
                            //     ws.text = suggestWord[1];
                            //   ws.length = suggestWord[1].Length;
                            // list.Add(ws);
                            //  ws.text = "";
                            //  ws.length = 0;
                            //    Console.WriteLine("sugg1-->{0}", suggestWord[i]);
                            // Thread.Sleep(5000);
                        }

                        //}

                    }
                    else
                    {
                        cleanTrueText();
                        /* for (int i = 0; i < suggestWord.Length; i++)
                         {


                           //  Console.WriteLine("ws-->{0}", suggestWord[i]);
                             WordSegmentEntry ws1 = new WordSegmentEntry();
                             ws1.text = suggestWord[i];

                             ws1.length = suggestWord[i].Length;
                             list.Add(ws1);
                             //    ws.text = suggestWord[0];
                             //  ws.length = suggestWord[0].Length;
                             //   list.Add(ws);
                             pointer++;

                         /*    try
                             {
                                 suggestChk = suggestWord[i] + suggestWord[i+1];
                                   Console.WriteLine("suggestChk2-->{0}", suggestChk);
                                 int chkSound1 = checkSoundex(suggestChk);
                                 if (chkSound1 == 0)
                                 {
                                     currentSeg[currPos].text = suggestWord[i];
                                     currentSeg[currPos].length = suggestWord[i].Length;
                                     list.Add(currentSeg[currPos]);
                                     pointer++;
                                 }

                                 else if (chkSound1 > 0)
                                 {
                                     currentSeg[currPos].text = suggestChk;
                                     currentSeg[currPos].length = suggestChk.Length;
                                     list.Add(currentSeg[currPos]);
                                     pointer++;
                                     //currPos++;
                                 }

                             }
                             catch (System.IndexOutOfRangeException e)  // CS0168
                             {
                                 // System.Console.WriteLine(e.Message);
                                 //set IndexOutOfRangeException to the new exception's InnerException
                                 //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                                 /*   string suggestChk = currentSeg[currPos].text ;
                                    Console.WriteLine("suggestChk2.1-->{0}", suggestChk);
                                    int chkSound1 = checkSoundex(suggestChk);
                                    if (chkSound1 == 0)
                                    {*/
                        /*currentSeg[currPos].text = suggestWord[i];
                        currentSeg[currPos].length = suggestWord[i].Length;
                        list.Add(currentSeg[currPos]);
                        pointer++;
                        /*  }

                          else if (chkSound1 > 0)
                          {
                              currentSeg[currPos].text = suggestChk;
                              currentSeg[currPos].length = suggestChk.Length;
                              list.Add(currentSeg[currPos]);
                              pointer++;
                              currPos++;
                          }*/
                        //  }
                        //  ws.text = "";
                        // ws.length = 0;
                        //   Thread.Sleep(5000);
                        //  ws.text = suggestWord[1];
                        //    ws.length = suggestWord[1].Length;
                        //    list.Add(ws);
                        //   Console.WriteLine("sugg2-->{0}", suggestWord[i]);
                        /*  }
                      */
                    }
                }
            }
            else
            {
                WordSegmentEntry ws = new WordSegmentEntry();
                string suggestChk = "";
                try
                {
                    suggestChk = selectText + currentSeg[currPos + 1].text;


                }
                catch (System.IndexOutOfRangeException e)  // CS0168
                {
                    System.Console.WriteLine(e.Message);
                    //set IndexOutOfRangeException to the new exception's InnerException
                    //throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
                }
                // Console.WriteLine("suggestChk2-->{0}", suggestChk);
                suggestWords = LDSuggestWord.GetSuggestLDWords(suggestChk);
                int chkSound = suggestWords.Length;

                if (chkSound > 0)
                {
                    ws.text = suggestChk;
                    ws.length = suggestChk.Length;
                    list.Add(ws);
                    pointer++;
                    // index++;
                    index++;
                    currPos++;

                }

                else if (chkSound == 0)
                {

                    ws.text = selectText;
                    ws.length = selectText.Length;
                    list.Add(ws);
                    pointer++;

                }

                //   WordSegmentEntry ws = new WordSegmentEntry();
                //   ws.text = selectText;
                // Console.WriteLine("selectText-->{0}", selectText);



                //    ws.length = selectText.Length;
                //   list.Add(ws);
            }
        }







        public int checkMostPriorty()
        {
            int retPosition = 0;

            int chk1, chk2, chk3;

            // string sugg="";
            suggestWords = LDSuggestWord.GetSuggestWords(suggestWord[0]);
            chk1 = suggestWords.Length;

            suggestWords = LDSuggestWord.GetSuggestWords(suggestWord[1]);
            chk2 = suggestWords.Length;

            suggestWords = LDSuggestWord.GetSuggestWords(suggestWord[0] + suggestWord[1]);
            chk3 = suggestWords.Length;

            // Console.WriteLine("chk1[{0}],chk2[{1}],chk3[{2}]",chk1,chk2,chk3);

            if (chk3 < chk1 && chk3 < chk2)
            {

                retPosition = 1;

            }

            return retPosition;
        }
        public WordSegmentEntry[] segmentation(WordSegmentEntry[] seg)
        {

            return seg.ToArray();
        }

        public int checkWrong()
        {
            int ret = 1;
            string zero = "0";
            for (int i = 0; i < status.Length; i++)
            {
                if (string.Compare(status[i].ToString(), zero) == 0)
                {
                    ret = 0;
                    // return ret;
                    //  break;

                }

                // Console.WriteLine("zero-->{0}",status[i]);
            }

            return ret;


        }

        public int checkSoundex(string word)
        {

            int chk = 0;
            List<SpellWordSuggestEntry> suggests = new List<SpellWordSuggestEntry>();
            HomophoneLib homo = NectecAPI.Instance.HomoPhone;
            LDWordSegment wseg = new LDWordSegment();
            // int offset = this.Paragraph.Range.Start.ToInt();
            string g2p = wseg.GetG2P(word);

            string[] soudexs = homo.Homophone(word, g2p).ToArray();
            // Console.WriteLine("selectText-->{0}", word);
            //  Console.WriteLine("g2p-->{0}", g2p.ToString());
            foreach (var s in soudexs)
            {
                //logger.Debug("soundex: "+s);
                if (suggests.Count < 100)
                {
                    SpellWordSuggestEntry ws1 = new SpellWordSuggestEntry();
                    ws1.Text = s;
                    ws1.Type = SuggestType.Soundex;
                    // Console.WriteLine("sound-->{0}", s.ToString());
                    //  suggests.Add(ws);
                }
                else
                {
                    break;
                }
                chk++;
            }


            return chk;
        }

        public void recheckText(string pText, string nText)
        {

           // UserDict userDict = Program.AuthUser.UserDict;
            // LongLexTo ltx = new LongLexTo();
            //

            //  if (pText != "")
            //  {
       
                // list=   LongLexTo.spellCheckWord(nText);
                LongLexTo.spellChkWord(nText);
                //list = (System.Collections.ArrayList)LongLexTo.spellCheckWord(nText.Trim());

                //    Console.WriteLine("{0} : {1}", list[0], list[1]);
                // java.lang.Class clazz = typeof(LongLexTo);
                //  java.lang.Thread.currentThread().setContextClassLoader(clazz.getClassLoader());

                //  object obj = new LongLexTo();


                //pText = nText;//test
                string path = Directory.GetCurrentDirectory();
                //   Console.WriteLine("{0}", path);
                // Console.WriteLine("{0}", path);
            



            //   }

        }

        public int ConvertStringDecimal(string stringVal)
        {
            int decimalVal = 0;

            //   Console.WriteLine("val-->{0}",stringVal);
            stringVal = "A";

            try
            {
                decimalVal = Convert.ToInt32(stringVal);
                //  System.Console.WriteLine(
                //    "The string as a decimal is {0}.", decimalVal);
            }
            catch (System.OverflowException)
            {
                // System.Console.WriteLine(
                //    "The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                // System.Console.WriteLine(
                //    "The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                // System.Console.WriteLine(
                //    "The string is null.");
            }
            //     Console.WriteLine("val-->{0}", decimalVal);
            return decimalVal;

            // Decimal to string conversion will not overflow.
            //   stringVal = System.Convert.ToString(decimalVal);
            //  System.Console.WriteLine(
            //     "The decimal as a string is {0}.", stringVal);
        }

        public void splitData(string splt)
        {
            // char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            char[] delimiterChars = { '|' };

            //  string text = "one\ttwo three:four,five six seven";
            //   System.Console.WriteLine("Original text: '{0}'", splt);

            string[] words = splt.Split(delimiterChars);
            suggestWord = new string[words.Length / 2];
            status = new string[words.Length / 2];
            //  System.Console.WriteLine("{0} words in text:", words.Length);
            int counts = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                // Console.WriteLine("word-->{0}", words[i]);
                //   if (i % 2 == 0)
                // {
                suggestWord[counts] = words[i];
                // }
                //else if (i / 2 == 1)
                //{
                status[counts] = words[i + 1];
                //}
                  //Console.WriteLine("sugg-->{0}", suggestWord[counts]);
                // Console.WriteLine("status-->{0}", status[counts]);
                counts++;
                i++;

            }


        }

        public string OpenFile(string fileName)
        {
            if (isDisposed)
                throw new ObjectDisposedException("peopleToRing");
            fs = new FileStream(fileName, FileMode.Open);
            sr = new StreamReader(fs);
            string firstLine = "";
            try
            {
                firstLine = sr.ReadLine();
                //   nPeopleToRing = uint.Parse(firstLine);
                isOpen = true;
            }
            catch (IOException e)
            {
                //Catch a IOException
                //  Console.WriteLine("An IOException Occurred :" + e);
            }

            catch (Exception e)
            {
                //Catch any other exception that occurs
                //  Console.WriteLine("An Exception Occurred :" + e);
            }
            fs.Close();
            sr.Close();
            return firstLine;
        }
        public string streamFile(string fileName)
        {

            StreamReader read;

            read = new StreamReader(File.OpenRead(fileName), Encoding.UTF8);
            //  StreamWriter write;
            // write = new StreamWriter(File.OpenWrite("destfile.txt"));

            // copy one file to the other, adding line numbers
            int line = 0;
            //    while (true)
            //   {
            string str = read.ReadLine();
            //     if (str == null) break;
            //     line++;
            //   write.WriteLine("{0:D4} {1}", line, str);
            //  }
            read.Close();
            //  Console.WriteLine("{0}" ,str);

            return str;
        }
    }
}