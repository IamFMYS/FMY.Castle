using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Castle.Log
{
    public interface ILogFormatter
    {
        string Format(string MsgStr);
    }
}
