using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewSelenium
{
    public class HttpResponseCode
    {
        public static void GetPage(string url)
        {
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                Console.WriteLine(myHttpWebResponse.StatusCode);

            } catch (WebException e)
            {
                Console.WriteLine("following error occured {0}", e.Status);
            }
        }
        public static void Main(string[] args)
        {
            GetPage("https://allegroe.pl/");
            Console.ReadKey();
        }
    }

}
//https://docs.microsoft.com/pl-pl/dotnet/api/system.net.httpwebresponse.statuscode?view=netframework-4.8