using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_statistics_json_deserialize
{
    public class Rootobject
    {
        public Confirmed confirmed { get; set; }
        public Recovered recovered { get; set; }
        public Deaths deaths { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}
