using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    static class LogService
    {
        static public void log(string text,string result)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var path = @"D:\";
            stringBuilder.Append(text);
            File.AppendAllText(path+"log.txt",stringBuilder.ToString() + "="+ result + Environment.NewLine);
        }
    }
}
