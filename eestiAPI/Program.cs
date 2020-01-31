using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eestiAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryUrl = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(categoryUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                var info = JsonConvert.DeserializeObject<List<Eesti>>(response);
                Console.WriteLine($"Name: {info[0].Name}");
                Console.WriteLine($"Cioc: {info[0].Cioc}");
                Console.WriteLine($"Capital: {info[0].Capital}");
                Console.WriteLine($"Region: {info[0].Region}");
                Console.WriteLine($"Population: {info[0].Population}");
                Console.WriteLine($"Domain: {info[0].topLevelDomain[0]}");
                Console.WriteLine($"Language: {info[0].Languages[0].Name}");
            }

            Console.ReadLine();

        }
    }
}
