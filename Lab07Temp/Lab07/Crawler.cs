using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07
{
    class Crawler
    {
        private string html;
        private string url;

        public Crawler(string url)
        {
            Url = url;
            html = new WebClient().DownloadString(Url);
        }

        public string Url { get { return url; } set { url = value; } }
        public string Html { get { return html; } set { html = value; } }

        public ArrayList FindInWebSite(String regex)
        {
            //Hiçbir eşleşme bulamazsa RegexNotFoundException firlatilacak. 

            ArrayList list = new ArrayList();

            Regex myRegex = new Regex(regex);
            MatchCollection myMatchCol = myRegex.Matches(Html);
            if (myMatchCol.Count > 0)
            {
                foreach (Match m in myMatchCol)
                {
                    list.Add(m.Value);
                }
            }
            else throw new RegexNotFoundException();
            return list;
        }

        public void ReplaceInWebsite(String regex, String regexrep)
        {
            // Buldu eşleşmeyi başka bir regex ile değiştecek.
            Html = Regex.Replace(Html, regex, regexrep);
        }

        public void SaveHtml()
        {
            //html'in o anki halini kaydedecek.

            string dosya_yolu = @".\dosya.txt";

            if (!File.Exists(dosya_yolu))
            {
                File.WriteAllText(dosya_yolu, Html, Encoding.UTF8);
            }
        }

    }
}
