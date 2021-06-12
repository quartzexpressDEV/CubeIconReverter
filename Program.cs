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
            /*if (Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) != filename)
            {
                File.WriteAllText("temp.bat", $"/C taskkill /f /im {Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)} & if exist CubeIconReverter.exe (del /q CubeIconReverter.exe )& ren {System.Reflection.Assembly.GetEntryAssembly().Location} {filename} & start CubeIconReverter@{Updater.releases.tag_name}.exe");
                Process.Start("cmd.exe", "temp.bat");
            }
            if (File.Exists("temp.bat"))
            {
                File.Delete("temp.bat");
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
