using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreintijdenSolution.Models
{
    public class Station
    {
        public string Alias { get; set; }

        public string Code { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public string Country { get; set; }

        public string Name { get; set; }
    }
}
