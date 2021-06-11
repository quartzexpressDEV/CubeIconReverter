using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CubeIconReverter
{
    static class Program
    {
        public static string filename = "CubeIconReverter.exe";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) != filename)
            {
                Process.Start("cmd.exe", $"/C taskkill /f /im {Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)} & ren {System.Reflection.Assembly.GetEntryAssembly().Location} {filename} & start {filename}");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
