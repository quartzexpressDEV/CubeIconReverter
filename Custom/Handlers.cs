using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIconReverter
{
    public static class Handlers
    {
        public static void ReportException(Exception e)
        {
            //if this causes an exception im gonna cry
            File.AppendAllText("log.txt", $"\n{DateTime.Now}\n{e}");
        }
    }
}
