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
                label3.Text = "cache cleared";
            }
            catch (Exception e)
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
                File.Delete($"{cachepath}\\default.zip");
                if (cubeTitleRemove.Checked)
                {
                    File.Delete($"{cachepath}\\anticcpack\\textures\\ui\\title.png");
                }
                if (healthBarYes.Checked)
                {
                    wc.DownloadFile($"{url}/healthbar.png", $"{cachepath}\\anticcpack\\font\\glyph_E1.png");
                }
                wc.Dispose();
            }
            catch (Exception e)
            {
                File.WriteAllText("log.txt", e.ToString());
                if (e is IOException) { label3.Text = "Error 1"; } else {
                if (e is UnauthorizedAccessException) { label3.Text = "Error 2"; } else {
                if (e is WebException) { label3.Text = "Error 3"; } else {
                if (e is FileNotFoundException) { label3.Text = "Error 4"; }}}}
            }
            cubeTitleRemove.Checked = false;
            healthBarYes.Checked = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
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
