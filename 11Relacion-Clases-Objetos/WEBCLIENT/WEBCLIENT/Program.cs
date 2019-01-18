using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WEBCLIENT
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient wc = new WebClient();
            string pagina = wc.DownloadString("http://www.x-rates.com/calculator/?from=EUR&to=USD");
            //Console.WriteLine(pagina);

            int pos = pagina.IndexOf("ccOutputRslt");
            Console.WriteLine(pagina.Substring(pos, 100));
            int pos2 = pagina.IndexOf("ccOutputTrail");
            Console.WriteLine(pagina.Substring(pos2,100));

            Console.ReadKey();

        }
    }
}
