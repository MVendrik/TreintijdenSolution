using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreintijdenSolution.Models
{
    public class Vertrektijden
    {
        public string Eindbestemming { get; set; }

        public int  Ritnummer { get; set; }

        public string RouteTekst { get; set; }

        public string Treinsoort { get; set; }

        public string Vertrekspoor { get; set; }

        public DateTime Vertrektijd { get; set; }

        public string VertrekVertragingTekst { get; set; }

    }
}
