using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CubeIconReverter
{
    public class Modules
    {
        //yes i know i couldve made this better but it was hurting my brain too much so i took the simple way
        public readonly string cachepath = $"{Environment.GetEnvironmentVariable("localappdata")}\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\localcache\\minecraftpe\\packcache\\resource";
        public static List<string> Get()
        {
            WebClient wc = new WebClient();
            var json = JsonConvert.DeserializeObject<modulesClass[]>(wc.DownloadString("https://raw.githubusercontent.com/quartzexpressDEV/anticcpack/main/_modules/health_bar/health_bar.json"));
            wc.Dispose();
            IEnumerable<string> ie = json.Select(modul => modul.name);
            List<string> a = new List<string>();
            a.AddRange(ie);
            return a;
        }
        public static string getFileNameByIndex(int index)
        {
            WebClient wc = new WebClient();
            var json = JsonConvert.DeserializeObject<modulesClass[]>(wc.DownloadString("https://raw.githubusercontent.com/quartzexpressDEV/anticcpack/main/_modules/health_bar/health_bar.json"));
            wc.Dispose();
            IEnumerable<string> ie = json.Select(modul => modul.fileName);
            List<string> a = new List<string>();
            a.AddRange(ie);
            return a[index];
        }
    }
    public class modulesClass
    {
        public string name { get; set; }
        public string fileName { get; set; }
    }
}
