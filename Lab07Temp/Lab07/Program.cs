using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Crawler crawler = new Crawler("http://csc.deu.edu.tr/");
                ArrayList a = crawler.FindInWebSite(@"\bH\S*r\b"); 
                foreach (Object o in a)
                {
                    if(o is string)
                    {
                        string s = ((string)o);
                       Console.WriteLine(s);
                    }
                }

                crawler.ReplaceInWebsite(@"\bH\S*r\b", "buldum");
                crawler.SaveHtml();
                Console.ReadKey();
            }
            catch (RegexNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir hata oluştu!");
            }
        }  
            
    }
}
