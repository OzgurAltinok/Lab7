using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class RegexNotFoundException : Exception
    {

        //Hiç argüman almayan, Sadece mesajı alan , Mesaj ve iç exception'i alan 3 farklı consturoctor tanımlanacak.

        public RegexNotFoundException()
        {

        }

        public RegexNotFoundException(string message)
        {

        }

        public RegexNotFoundException(string message, Exception e)
        {

        }
    }
}
