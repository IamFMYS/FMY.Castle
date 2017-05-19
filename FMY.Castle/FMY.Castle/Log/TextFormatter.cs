using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Castle.Log
{
    public class TextFormatter : ILogFormatter
    {
        public TextFormatter()
        {
        }

        public string Format(string MsgStr)
        {
            return "[" + MsgStr + "]";
        }
    }
}
