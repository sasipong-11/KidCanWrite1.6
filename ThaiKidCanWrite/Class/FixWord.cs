using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LDWordProcessor.Class
{
    class FixWord
    {
        public String CheckWord(String Word)
        {

            switch (Word)
            {
                case "นึ่ง": Word = "หนึ่ง"; break;
                case "จอลาเค้": Word = "จระเข้"; break;
                case "เขมซ้าน": Word = "เข็มสั้น"; break;
                case "โขมย": Word = "ขโมย"; break;
                case "ขะโมย": Word = "ขโมย"; break;
                case "ท่": Word = "ที่"; break;
                case "ซะบาย": Word = "สบาย"; break;
                case "เสด": Word = "เสร็จ"; break;
                case "ยากด้าย": Word = "อยากได้"; break;
                case "โกม": Word = "กลม"; break;
                case "โตมม้าย": Word = "ต้นไม้"; break;
                case "พลละม้าย": Word = "ผลไม้"; break;
                case "พูขัว": Word = "ภูเขา"; break;
                case "ครุคระ": Word = "ขรุขระ"; break;
                default: Word = Word; break;

            }
            return Word;
        }
    }
}
