using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor
{
    class TooltipCustomItem : ToolStripControlHost
    {
        public UserControl1 innerControl;
        public UserControl2 innerControl2;
        public TooltipCustomItem(UserControl1 c)
            : base(c)
        {
            innerControl = c;
        }
        public TooltipCustomItem(UserControl2 c2)
            : base(c2)
        {
            innerControl2 = c2;
        }
    }
}
