using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api;
using Microsoft.VisualBasic;
using LDWordProcessor;
using System.IO;
using NLog;
using System.Text.RegularExpressions;
using System.Diagnostics;


public class LDWordSegment
{
    private static Logger logger = LogManager.GetCurrentClassLogger();
    private MainAnalysis api;

    public LDWordSegment()
    {
        api = NectecAPI.Instance.WordSegment;
    }

    public string GetWordSegment(string str)
    {
        logger.Debug("GetWordSegment" + str);

        return api.WordSegMethodOrg(str);
    }

    public string GetG2P(string str)
    {
        return api.GetG2P(str);
    }

    class WordToken
    {
        public int start;
        public int countLineFeed;
    }

    public WordSegmentEntry[] GetWordSegmentPos(string str, string strSegment)
    {
        Trace.WriteLine("str.Length: " + str.Length);
        Trace.WriteLine("strSegment.Length:" + strSegment.Length);
        List<WordSegmentEntry> ret = new List<WordSegmentEntry>();
        char[] arr = strSegment.ToCharArray();
        //LDUtils.printChars(arr);

        List<WordToken> startList = new List<WordToken>();
        int j = 0;
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '|')
            {
                WordToken wt = new WordToken();
                wt.start = j - startList.Count;
                wt.countLineFeed = k;
                startList.Add(wt);
            }
            else if(arr[i] == '\r')
            {
                k++;
            }

            j++;

            
            //if (arr[i] != '\n')
            //{
            //    j++;
            //}
        }

        for (int i = 0; i < startList.Count; i++)
        {
            if (i < startList.Count - 1)
            {
                WordToken wt = startList[i];
                WordSegmentEntry wss = new WordSegmentEntry();
                wss.start = wt.start;
                wss.startNonLF = wt.start - wt.countLineFeed;
                wss.length = startList[i + 1].start - wt.start;
                wss.text = str.Substring(wss.start, wss.length);
                //logger.Debug("{0}-{1}-{2}", wss.start, wss.startNonLF, wss.text);
                if (wss.length < 0) wss.length = 0;

                ret.Add(wss);
            }
        }

        Trace.WriteLine("return " + ret.Count);
 
        return ret.ToArray();
    }

    public int CountWord(string str)
    {
        string strSegment = GetWordSegment(str);
        WordSegmentEntry[] wsList = GetWordSegmentPos(str, strSegment);
        int n = 0;
        foreach (var wse in wsList)
        {
            n++;
        }
        return n;
    }

    public string GetLastThaiWord(string str)
    {
        if (str != null && str.Length > 2)
        {
            string wstr = GetWordSegment(str);
            int startIndex = wstr.Length - 2;
            if (startIndex > 0)
            {
                int i = wstr.LastIndexOf('|', startIndex);
                if (i > 0)
                {
                    int len = wstr.Length - i - 2;
                    if (len > 0)
                    {
                        return wstr.Substring(i + 1, len);
                    }
                }
            }
        }

        return str;
    }
}
