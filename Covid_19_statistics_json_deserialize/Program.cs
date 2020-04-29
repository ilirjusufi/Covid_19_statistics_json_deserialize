using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_statistics_json_deserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var get = new WebClient();
            var text = get.DownloadString("https://covid19.mathdro.id/api/");//references by mathdro.id
            Rootobject getjsonvalues = JsonConvert.DeserializeObject<Rootobject>(text);
            Console.WriteLine("Corona virus statistces in all world \nTotal Confirmet: {0} Poples \nTotal Recoverd:{1} Poples \nTotal Deaths:{2} Poples", getjsonvalues.confirmed.value, getjsonvalues.recovered.value, getjsonvalues.deaths.value);
            c:
            Console.WriteLine("Search for your Country for statistces");
            string search = Console.ReadLine();
            var getcontryes = new WebClient();
            string contryurl = "https://covid19.mathdro.id/api/countries/" + search;
            var textcontryes = get.DownloadString(contryurl);//references by mathdro.id
            Rootobject getjsonvaluesc = JsonConvert.DeserializeObject<Rootobject>(textcontryes);
            Console.WriteLine("Corona virus statistces in your Country {0}\nTotal Confirmet: {1} Poples \nTotal Recoverd:{2} Poples \nTotal Deaths:{3} Poples", search, getjsonvaluesc.confirmed.value, getjsonvaluesc.recovered.value, getjsonvaluesc.deaths.value);
            Console.WriteLine("If you want to search for other contry pres y if not pres n");
            string searchother = Console.ReadLine();
            if (searchother == "y")
            {
                goto c;
            }
        }
    }
}
