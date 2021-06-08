using System;
using System.Drawing;
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
                status.Text = "cache cleared";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                status.Text = $"error: {e.Message}";
            }

        }
        private void dl_pack()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile($"{url}/default.zip", $"{cachepath}\\default.zip");
                ZipFile.ExtractToDirectory($"{cachepath}\\default.zip", $"{cachepath}\\anticcpack");
                status.Text = "pack downloaded";
                File.Delete($"{cachepath}\\default.zip");
                if (removecubeTitle.Checked)
                {
                    File.Delete($"{cachepath}\\anticcpack\\textures\\ui\\title.png");
                }
                if (customHealthBar.Checked)
                {
                    wc.DownloadFile($"{url}/healthbar.png", $"{cachepath}\\anticcpack\\font\\glyph_E1.png");
                }
                wc.Dispose();
            }
            catch (Exception e)
            {
                File.WriteAllText("log.txt", e.ToString());
                if (e is IOException) { status.Text = "Error 1"; } else {
                if (e is UnauthorizedAccessException) { status.Text = "Error 2"; } else {
                if (e is WebException) { status.Text = "Error 3"; } else {
                if (e is FileNotFoundException) { status.Text = "Error 4"; }}}}
            }
            removecubeTitle.Checked = false;
            customHealthBar.Checked = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void appTitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + "https://github.com/quartzexpressDEV/CubeIconReverter/");
        }

        void Header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        void Header_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drag = true;
        }

        void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X,
                                     p2.Y - startPoint.Y);
                Location = p3;
            }
        }
    }
}
