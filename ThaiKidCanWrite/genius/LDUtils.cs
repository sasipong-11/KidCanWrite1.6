using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace LDWordProcessor
{
    public class LDUtils
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void printList(List<string> list, string header = "")
        {
            logger.Debug("============================");
            logger.Debug(header);
            foreach (var s in list)
            {
                logger.Debug(s);
            }
            logger.Debug("============================");
        }

        public static void printBytes(byte[] bytes, string header = "")
        {
            logger.Debug("============================");
            logger.Debug(header);
            foreach (var byt in bytes)
            {
                logger.Debug("{0}={0:X2}", byt);
            }
            logger.Debug("============================");
        }

        public static void printChars(char[] chars, string header = "")
        {
            logger.Debug("============================");
            logger.Debug(header);
            int i=0;
            foreach (var c in chars)
            {
                logger.Debug("{0}={1:X2}-{1}-{2}", c, (int)c, i++);
            }
            logger.Debug("============================");
        }

    }

}