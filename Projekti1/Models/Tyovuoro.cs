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

        public Tyovuoro()
        {
        }

        public Tyovuoro(DateTime alkaa, DateTime loppuu) : this()
        {
            Alkaa = alkaa;
            Loppuu = loppuu;
        }
    }
}
