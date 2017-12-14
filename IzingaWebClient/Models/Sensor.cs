using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaWebClient.Models
{
    public class Sensor
    {
        public string Type { get; set; }
        public string ID { get; set; }

        public Sensor(string type, string id)
        {
            Type = type;
            ID = id;
        }

        public Sensor()
        {

        }
    }
}