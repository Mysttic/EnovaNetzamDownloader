using EnovaNetzamDownloader.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnovaNetzamDownloader
{
    internal class Tools
    {        
        public static bool VerifyVersion(string text)
        {
            return !string.IsNullOrWhiteSpace(CalcVersion(text));
        }

        public static string CalcVersion(string text)
        {
            string version = "";
            if (text.Split(new char[] { '.' }).Count() == 3)
                if (text.Split('.')[0].Length == 4 && text.Split('.')[1].Length > 0 && text.Split('.')[2].Length > 0)
                    foreach (string s in text.Split('.'))
                        if (int.TryParse(s, out int value))
                            version += s + ".";
            return version.Length > 1 ? version.Substring(version.Length - 1) : version;
        }

        public static string[] CalcVersions(string text)
        {
            string v = text;// CalcVersion(text);
            return new[] { v.Substring(0, 4), v.Substring(5, v.Length - 5) };
        }

        public static void Download(string url,string text)
        {
            if (!Settings.Default.SavedVersions.Contains(text))
            {
                Settings.Default.SavedVersions.Add(text);
                Settings.Default.Save();                
            }
            string[] vs = Tools.CalcVersions(text);
            url = url.Replace("{version1}", vs[0]).Replace("{version2}", vs[1]);
            OpenUrl(url);
        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
