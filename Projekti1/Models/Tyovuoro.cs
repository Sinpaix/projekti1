using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tyovuoro
    {
        public int Idtyovuoro { get; set; }
        public DateTime Alkaa { get; set; }
        public DateTime Loppuu { get; set; }

        public string VuoroAlkaa { get; set; }
        public string VuoroLoppuu { get; set; }

        public Tyovuoro()
        {
        }

        public Tyovuoro(int idtyovuoro, DateTime alkaa, DateTime loppuu) : this()
        {
            Idtyovuoro = idtyovuoro;
            Alkaa = alkaa;
            Loppuu = loppuu;
        }

        public Tyovuoro(int idtyovuoro, string vuoroAlkaa, string vuoroLoppuu)
        {
            Idtyovuoro = idtyovuoro;
            VuoroAlkaa = vuoroAlkaa;
            VuoroLoppuu = vuoroLoppuu;
        }
    }
}
