using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Castle.Log
{
    public class TextFileLog : ILog
    {
        private string _target;

        private ILogFormatter _format;

        public TextFileLog(string target, ILogFormatter format)
        {
            this._target = target;  
            this._format = format;
        }

        public void Write(string MsgStr)
        {
            string _MsgStr = _format.Format(MsgStr);
            _MsgStr += _target;
            //Output Message
            Console.WriteLine("Output " + _MsgStr);
        }
    }
}
