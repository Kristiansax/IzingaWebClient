using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaWebClient.Models
{
    public class Institution
    {
        public string Department { get; set; }
        public string Residence { get; set; }

        public Institution(string department, string residence)
        {
            Department = department;
            Residence = residence;
        }
        public Institution()
        {

        }
    }
}