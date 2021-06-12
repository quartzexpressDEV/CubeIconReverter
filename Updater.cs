using System.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace CubeIconReverter
{
    class Updater
    {
        public static string version = "1.3.1";
        public static string pathToExe = Path.GetDirectoryName(Application.ExecutablePath);
        public static LatestReleases releases = new LatestReleases();
        public static LatestReleases Get()
        {
            CubeIconReverter.Updater.LatestReleases json = new CubeIconReverter.Updater.LatestReleases();
            WebClient wc = new WebClient();
            wc.Headers.Add("User-Agent", "request");
            try
            {
                json = JsonConvert.DeserializeObject<LatestReleases>(wc.DownloadString("https://api.github.com/repos/quartzexpressDEV/CubeIconReverter/releases/latest"));
            
                catch(Exception e)
            {
                Handlers.ReportException(e);
            }
            wc.Dispose();
            Updater.releases = json;
            return json;
        }

        public static void Update()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(Updater.releases.assets[0].browser_download_url, $"{Updater.pathToExe}\\CubeIconReverter@{releases.tag_name}.exe");
                wc.Dispose();
            }
            catch (Exception e) { Handlers.ReportException(e); }
            
            Process newApp = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $"CubeIconReverter@{releases.tag_name}.exe"
                }
            };

            newApp.Start();
            Application.Exit();
        }

        public static void DeleteOldVersion()
        {
            Thread.Sleep(1000);
            string[] files = Directory.GetFiles(pathToExe);


            for (int i = 0; i < files.Length; i++)
            {
                if (Path.GetFileName(files[i]).StartsWith("CubeIconReverter") && Path.GetFileName(files[i]).EndsWith(".exe") && Path.GetFileName(files[i]) != $"CubeIconReverter@{version}.exe")
                {
                    try
                    {
                        File.Delete($"{files[i]}");
                    }
                    catch (Exception e)
                    {
                        Handlers.ReportException(e);
                    }
                }
            }
        }

        public class Author
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class Uploader
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class Asset
        {
            public string url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string name { get; set; }
            public object label { get; set; }
            public Uploader uploader { get; set; }
            public string content_type { get; set; }
            public string state { get; set; }
            public int size { get; set; }
            public int download_count { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string browser_download_url { get; set; }
        }

        public class LatestReleases
        {
            public string url { get; set; }
            public string assets_url { get; set; }
            public string upload_url { get; set; }
            public string html_url { get; set; }
            public int id { get; set; }
            public Author author { get; set; }
            public string node_id { get; set; }
            public string tag_name { get; set; }
            public string target_commitish { get; set; }
            public string name { get; set; }
            public bool draft { get; set; }
            public bool prerelease { get; set; }
            public DateTime created_at { get; set; }
            public DateTime published_at { get; set; }
            public IList<Asset> assets { get; set; }
            public string tarball_url { get; set; }
            public string zipball_url { get; set; }
            public string body { get; set; }
        }
    }
}
