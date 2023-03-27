using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace indexAutorun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //直下にある doc\index.pdf を読み込む
            Process ps = new Process();
            ps.StartInfo.FileName = @"index.pdf";
            ps.Start();
        }
    }
}

