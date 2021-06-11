using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace CubeIconReverter
{
    public partial class Form1 : Form
    {
        public string version = Updater.version;
        private readonly string cachepath = $"{Environment.GetEnvironmentVariable("localappdata")}\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\localcache\\minecraftpe\\packcache\\resource";
        private readonly string url = "https://github.com/quartzexpressDEV/anticcpack/archive/refs/heads/main.zip";
        int hbSelectedIndex = -1;
        List<string> hbNames = new List<string>();

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
                if (e is IOException) { status.Text = "Error 1"; }
                if (e is UnauthorizedAccessException) { status.Text = "Error 2"; }
                if (e is DirectoryNotFoundException) { status.Text = "Error 4"; }
            }

        }
        private void dl_pack()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(url, $"{cachepath}\\default.zip");
                wc.Dispose();
                ZipFile.ExtractToDirectory($"{cachepath}\\default.zip", $"{cachepath}");
                Directory.Move($"{cachepath}\\anticcpack-main", $"{cachepath}\\anticcpack");
                status.Text = "pack downloaded";
                File.Delete($"{cachepath}\\default.zip");
                if (removecubeTitle.Checked)
                {
                    File.Delete($"{cachepath}\\anticcpack\\textures\\ui\\title.png");
                }
                if (customHealthBar.Checked)
                {
                    string filename = Modules.getFileNameByIndex(hbSelectedIndex);
                    File.Delete($"{cachepath}\\anticcpack\\font\\glyph_E1.png");
                    File.Move($"{cachepath}\\anticcpack\\_modules\\health_bar\\{filename}", $"{cachepath}\\anticcpack\\font\\glyph_E1.png");
                }
            }
            catch (Exception e)            {
                File.WriteAllText("log.txt", e.ToString());
                if (e is IOException) { status.Text = "Error 1"; } else
                if (e is UnauthorizedAccessException) { status.Text = "Error 2"; } else
                if (e is WebException) { status.Text = "Error 3"; } else
                if (e is ArgumentOutOfRangeException) { status.Text = "Please select a custom health bar"; } else
                if (e is FileNotFoundException) { status.Text = "Error 4"; } else {
                    status.Text = "Unknown Error";
                }
            }
            removecubeTitle.Checked = false;
            customHealthBar.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Updater.DeleteOldVersion();
            Modules.Get().ForEach((name) => hbNames.Add(name));
            if (version != Updater.Get().tag_name) {
                DialogResult result = MessageBox.Show($"New Update v{Updater.releases.tag_name}\nDo you want to update?\nThis is new:\n\n{Updater.releases.body}\n", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    Updater.Update();
                }
            };
            update.Text = Updater.version;
            hbSelectBtn.Hide();
        }
        private void customHealthBar_CheckedChanged(object sender, EventArgs e)
        {
            if (customHealthBar.Checked)
            {
                hbSelectBtn.Show();
                start.Enabled = false;
            }
            else
            {
                hbSelectBtn.Hide();
                start.Enabled = true;
            }
        }
        private void hbSelectBtn_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            // create fake items list

            var listViewItems = hbNames.ConvertAll(x => new ListViewItem(x));
            listViewItems.ForEach(lvi =>
            {
                //lvi.ForeColor = Color.FromArgb(255, 255, 255);
            });

            ListView listView = new ListView();
            listView.View = View.Tile;
            listView.MultiSelect = false;
            //listView.BackColor = Color.FromArgb(10, 20, 40);
            
            listView.Items.AddRange(listViewItems.ToArray());

            // calculate size of list from the listViewItems' height
            int itemToShow = listViewItems.Count;
            var lastItemToShow = listViewItems[listViewItems.GetRange(0, itemToShow).Count - 1];
            int height = lastItemToShow.Bounds.Bottom + listView.Margin.Top;
            listView.Height = height;

            listView.HotTracking = false;
            listView.Activation = ItemActivation.OneClick;
            listView.ItemActivate += new EventHandler(listView_ItemActivate);

            // create a new popup and add the list view to it
            var popup = new ToolStripDropDown();
            popup.AutoSize = false;
            popup.Margin = Padding.Empty;
            popup.Padding = Padding.Empty;
            ToolStripControlHost host = new ToolStripControlHost(listView);
            host.Margin = Padding.Empty;
            host.Padding = Padding.Empty;
            host.AutoSize = false;
            host.Size = new Size(200, 150);
            popup.Size = new Size(200, 150);
            popup.Items.Add(host);

            // show the popup
            popup.Show(this, button.Left, button.Bottom);
        }
        private void listView_ItemActivate(object sender, EventArgs e)
        {
            var listview = sender as ListView;
            var item = listview.SelectedItems[0].Index;
            var dropdown = listview.Parent as ToolStripDropDown;

            this.hbSelectBtn.Text = listview.SelectedItems[0].Text;

            listview.SelectedIndexChanged -= listView_ItemActivate;
            dropdown.Close();

            hbSelectedIndex = item;

            if (hbSelectedIndex >= 0)
            {
                start.Enabled = true;
            }
        }

        //----------------------------------------------------------------

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void appTitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/quartzexpressDEV/CubeIconReverter/");
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
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                Location = p3;
            }
        }

        }
}
