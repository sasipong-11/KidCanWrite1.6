using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Utils;
using NLog;
using System.IO;
using WordProcLD;
using api;
using LDWordProcessor.form;
using DevExpress.XtraWaitForm;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Drawing;
using System.Diagnostics;

#pragma warning disable 0169

namespace LDWordProcessor.genius
{
    //public class LDSpellChecker
    //{
    //    private static Logger logger = LogManager.GetCurrentClassLogger();
    //    private SpellCheckerIgnore ignoreList;
    //    private SpellChecked checkedList;
    //    private RichEditControl iRichEdit;
    //    private UserDict userDict = Program.AuthUser.UserDict;
    //    private LDFileBinding currentFile;
    //    private WaitForm waitForm;
    //    private BackgroundWorker bw;

    //    public LDSpellChecker(RichEditControl richEdit, LDFileBinding file)
    //    {
    //        iRichEdit = richEdit;
    //        currentFile = file;
    //        ignoreList = new SpellCheckerIgnore(file);
    //        checkedList = new SpellChecked(file);

    //        bw = new BackgroundWorker();
    //        bw.DoWork += new DoWorkEventHandler(bw_DoWork);
    //        bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
    //    }

    //    public void Start()
    //    {
    //        Document doc = iRichEdit.Document;
    //        bool stop = false;
    //        bool needCheck = false;
    //        int lastIndex = 0;

    //        do
    //        {
    //            SplashScreenManager.ShowForm(null, typeof(SpellCheckSplashScreen), true, true, false);

    //            LDParagraph ldp = null;
    //            //get all paragraph in document
    //            ParagraphCollection pcoll = doc.Paragraphs;
    //            needCheck = false;
    //            int i = lastIndex;

    //            while (i < pcoll.Count)
    //            {
    //                Paragraph p = pcoll[i];
    //                if (p.Range.Length > 1)
    //                {
    //                    ldp = new LDParagraph(this, doc, p);
    //                    //find in cache
    //                    if (!checkedList.Exist(ldp.Text))
    //                    {//not found
    //                        needCheck = true;
    //                        lastIndex = i + 1;
    //                        break;
    //                    }
    //                }
    //                i++;
    //            }

    //            if (needCheck)
    //            {
    //                List<MisSpellingEntry> misSpellList = ldp.SpellCheck();
    //                if (misSpellList.Count > 0)
    //                {

    //                    SplashScreenManager.CloseForm(false);

    //                    SpellCheckerForm f = new SpellCheckerForm(this, ldp, misSpellList);

    //                    if (f.ShowDialog() == DialogResult.Cancel)
    //                    {
    //                        stop = true;
    //                        break;
    //                    }
    //                }
    //                else
    //                {
    //                    checkedList.Add(ldp.Text);
    //                }
    //            }

    //            SplashScreenManager.CloseForm(false);
    //            if (i >= pcoll.Count - 1)
    //            {
    //                break;
    //            }


    //        } while (!stop);


    //    }

    //    private void bw_DoWork(object sender, DoWorkEventArgs e)
    //    {
    //        LDSpellChecker obj = (LDSpellChecker)e.Argument;
    //        //obj.NextSpellCheckParagraph();
    //    }

    //    private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    //    {
    //        waitForm.Close();
    //        waitForm = null;
    //        //ShowUI();
    //    }

    //    public void AddToDict(string s)
    //    {
    //        Program.AuthUser.UserDict.Add(s);
    //    }

    //    public void AddChecked(string text)
    //    {
    //        checkedList.Add(text);
    //    }

    //    public void Save()
    //    {
    //        IgnoreList.Save(CurrentFile);
    //        checkedList.Save(CurrentFile);
    //        UserDict.Save();
    //    }


    //    #region Property
    //    public SpellCheckerIgnore IgnoreList
    //    {
    //        get { return ignoreList; }
    //    }

    //    public UserDict UserDict
    //    {
    //        get { return userDict; }
    //        set { userDict = value; }
    //    }

    //    public LDFileBinding CurrentFile
    //    {
    //        get { return currentFile; }
    //        set { currentFile = value; }
    //    }
    //    #endregion
    //}

    public class LDSpellChecker
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private SpellCheckerIgnore ignoreList;
        private SpellChecked checkedList;
        private RichEditControl iRichEdit;
        //private UserDict userDict = Program.AuthUser.UserDict;
        private LDFileBinding currentFile;
        private WaitForm waitForm;
        private List<MisSpellingEntry> misSpellList = null;
        //private BackgroundWorker bw;

        public LDSpellChecker(RichEditControl richEdit, LDFileBinding file)
        {
            iRichEdit = richEdit;
            currentFile = file;
            ignoreList = new SpellCheckerIgnore(file);
            checkedList = new SpellChecked(file);

            //bw = new BackgroundWorker();
            //bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //bw.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        public SpellWordSuggestEntry[] getMisspell(Paragraph paragraph, DocumentPosition position, out int errStart, out int errLength)
        {
            if (paragraph.Range.Length > 1)
            {
                if (misSpellList != null)
                {//not found
                    foreach (MisSpellingEntry error in misSpellList)
                    {
                        if (error.IsError)
                        {
                            //DocumentHelper.SetSpellHilight(iRichEdit.Document, error.Start, error.Length, Color.LightPink);
                            if (error.IsInRage(position.ToInt() - paragraph.Range.Start.ToInt()))
                            {
                                errStart = error.Start;
                                errLength = error.Length;
                                return error.SuggestWords;
                            }
                        }
                    }
                    //lastIndex = i + 1;
                    //break;
                }

            }
            SpellWordSuggestEntry[] spellWordSuggestEntry = new SpellWordSuggestEntry[0];
            errStart = 0;
            errLength = 0;
            return spellWordSuggestEntry;
        }

        public void AdjustPosotion(int StartPosition, int Length)
        {
            int itemLength = 0;

            foreach (var item in misSpellList)
            {
                if (item.Start == StartPosition)
                {
                    itemLength = item.Length;
                    continue;
                }

                if (itemLength > 0)
                {
                    item.Start += (Length - itemLength);
                }
            }
        }

        public void run()
        {
            Document doc = iRichEdit.Document;
            int lastIndex = 0;
            int i = lastIndex;
            LDParagraph ldp = null;

            

            if (doc.Selection.Length > 0)
            {
                Paragraph p = doc.GetParagraph(doc.Selection.Start);
                ldp = new LDParagraph(this, doc, p, iRichEdit);
                int paragraphStart = p.Range.Start.ToInt();
                //find in cache
                if (!checkedList.Exist(ldp.Text))
                {//not found
                    misSpellList = ldp.SpellCheck();
                    foreach (MisSpellingEntry error in misSpellList)
                    {
                        if (error.IsError)
                        {
                            DocumentHelper.SetSpellHilight(iRichEdit.Document, error.Start + paragraphStart, error.Length, Color.LightPink, iRichEdit);
                          //  DocumentHelper.SetSpellHilight(iRichEdit.Document, error.Start + paragraphStart, error.Length, Color.Yellow, iRichEdit);
                        }
                    }
                    //lastIndex = i + 1;
                    //break;
                }
            }
            else
            {
                //get all paragraph in document
                ParagraphCollection pcoll = doc.Paragraphs;

                while (i < pcoll.Count)
                {
                    Paragraph p = pcoll[i];
                    if (p.Range.Length > 1)
                    {
                        ldp = new LDParagraph(this, doc, p, iRichEdit);
                        int paragraphStart = p.Range.Start.ToInt();
                        //find in cache
                        if (!checkedList.Exist(ldp.Text))
                        {//not found
                            misSpellList = ldp.SpellCheck();
                            foreach (MisSpellingEntry error in misSpellList)
                            {
                                if (error.IsError)
                                {
                                   // DocumentHelper.SetSpellHilight(iRichEdit.Document, error.Start + paragraphStart, error.Length, Color.Yellow, iRichEdit);
                                    DocumentHelper.SetSpellHilight(iRichEdit.Document, error.Start + paragraphStart, error.Length, Color.LightPink, iRichEdit);
                                }
                            }
                            //lastIndex = i + 1;
                            //break;
                        }
                    }
                    i++;
                }
            }

        /*MainForm.Instance().Invoke(new Func<object>(() => 
            {
                MainForm.Instance().barEditProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                MainForm.Instance().barButtonStopChecking.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                return null;
            }
            ));*/
        }

        #region Property
        public SpellCheckerIgnore IgnoreList
        {
            get { return ignoreList; }
        }

    /*    public UserDict UserDict
        {
            get { return userDict; }
            set { userDict = value; }
        }*/

        public LDFileBinding CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        } 
        #endregion
    }
}
