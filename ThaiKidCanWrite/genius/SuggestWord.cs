using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordProcLD;
using NLog;

namespace LDWordProcessor
{
    public class LDSuggestWord
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static SpellWordSuggestEntry[] GetSuggestLDWords(string word, int limit = 100)
        {
            HomophoneLib homo = NectecAPI.Instance.HomoPhone;
            SpellingLib spell = NectecAPI.Instance.Spelling;
            LDWordSegment wseg = new LDWordSegment();

            List<SpellWordSuggestEntry> suggests = new List<SpellWordSuggestEntry>();
            //1. Soundex Method 
            string g2p = wseg.GetG2P(word);
            string[] soudexs = homo.Homophone(word, g2p).ToArray();
            //logger.Debug("look up suggestion: "+word);
            foreach (var s in soudexs)
            {
                //logger.Debug("soundex: "+s);
                if (suggests.Count < limit)
                {
                    SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                    ws.Text = s;
                    ws.Type = SuggestType.Soundex;
                    suggests.Add(ws);
                }
                else
                {
                    break;
                }
            }

            //2. SpellLD
            if (suggests.Count < limit)
            {
                List<string> spll = new List<string>();
                //List<string> spll = spell.GetSpellLD(word);
                //foreach (var s in spll)
                //{
                //    //logger.Debug("SpellLD: " + s);
                //    if (suggests.Count < limit)
                //    {
                //        SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                //        ws.Text = s;
                //        ws.Type = SuggestType.Approx;
                //        suggests.Add(ws);
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}

                if (spll.Count == 0)
                {
                    //3. SpellMore
                    if (suggests.Count < limit)
                    {
                        List<string> spll2 = spell.GetSpellLD(word);
                        foreach (var s in spll2)
                        {
                            //logger.Debug("SpellMore: " + s);
                            if (suggests.Count < limit)
                            {
                                SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                                ws.Text = s;
                                ws.Type = SuggestType.Approx;
                                if (!soudexs.Contains(s))
                                {
                                    suggests.Add(ws);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return suggests.ToArray();
        }

        public static SpellWordSuggestEntry[] GetSuggestWords(string word, int limit = 100)
        {
            HomophoneLib homo = NectecAPI.Instance.HomoPhone;
            SpellingLib spell = NectecAPI.Instance.Spelling;
            LDWordSegment wseg = new LDWordSegment();

            List<SpellWordSuggestEntry> suggests = new List<SpellWordSuggestEntry>();
            //1. Soundex Method 
            string g2p = wseg.GetG2P(word);
            string[] soudexs = homo.Homophone(word, g2p).ToArray();
            logger.Debug("look up suggestion: "+word);
            foreach (var s in soudexs)
            {
                logger.Debug("soundex: "+s);
                if (suggests.Count < limit)
                {
                    SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                    ws.Text = s;
                    ws.Type = SuggestType.Soundex;
                    suggests.Add(ws);
                }
                else
                {
                    break;
                }
            }

            //2. SpellLD
            if (suggests.Count < limit)
            {
                //List<string> spll = new List<string>();
                List<string> spll = spell.GetSpellLD(word);
                foreach (var s in spll)
                {
                    logger.Debug("SpellLD: " + s);
                    if (suggests.Count < limit)
                    {
                        SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                        ws.Text = s;
                        ws.Type = SuggestType.Approx;
                        suggests.Add(ws);
                    }
                    else
                    {
                        break;
                    }
                }
                //3. SpellMore
                if (suggests.Count < limit)
                {
                    List<string> spll2 = spell.GetSpellMore(word);
                    //  List<string> spll2 = spell.GetSpellLD(word);
                    foreach (var s in spll2)
                    {
                        logger.Debug("SpellMore: " + s);
                        if (suggests.Count < limit)
                        {
                            SpellWordSuggestEntry ws = new SpellWordSuggestEntry();
                            ws.Text = s;
                            ws.Type = SuggestType.Approx;
                            if (!soudexs.Contains(s))
                            {
                                suggests.Add(ws);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            //first grouping text and then picking the first item from each group (remove duplicate item)
            suggests = suggests.GroupBy(i => i.Text).Select(g => g.First()).ToList();

            return suggests.ToArray();
        }
    }
}
