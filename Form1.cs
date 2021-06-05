using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeIconReverter
{
    public partial class Form1 : Form
    {
        readonly string cache = Environment.GetEnvironmentVariable("localappdata") + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\localcache\\minecraftpe\\packcache\\";
        readonly string json = "";
        readonly string downloadurl = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void revert_Click(object sender, EventArgs e)
        {
            label1.Text = packdir();
        }

        private void reset_Click(object sender, EventArgs e)
        {

        }
        private string packdir()
        {
            string[] folders = Directory.GetFiles(cache);
            foreach(string fold in folders)
            {
                Console.WriteLine(fold);
                if (File.Exists($"{fold}\\manifest.json") && File.ReadAllText($"{fold}\\manifest.json") == json)
                {
                    return fold;
                }
            }
            return null;
        }
    }
}
