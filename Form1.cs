using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace CubeIconReverter
{
    public partial class Form1 : Form
    {
        private readonly string cachepath = $"{Environment.GetEnvironmentVariable("localappdata")}\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\localcache\\minecraftpe\\packcache\\resource";
        private readonly string url = "https://reinindieol.ga/cdn/cubeiconreverter/packs";
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            clearcache();
            dl_pack();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearcache();
        }
        private void clearcache()
        {
            try
            {
                Directory.Delete(cachepath, true);
                Directory.CreateDirectory(cachepath);
                label3.Text = "cache cleared";
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                label3.Text = $"error: {e.Message}";
            }
            
        }
        private void dl_pack()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile($"{url}/default.zip", $"{cachepath}\\default.zip");
                ZipFile.ExtractToDirectory($"{cachepath}\\default.zip", $"{cachepath}\\anticcpack");
                label3.Text = "pack downloaded";
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                label3.Text = $"error: {e.Message}";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + "https://github.com/quartzexpressDEV/CubeIconReverter/");
        }
    }
}
