using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaWebClient.Models
{
    public class Personnel
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Personnel(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public Personnel()
        {

        }
    }
}
