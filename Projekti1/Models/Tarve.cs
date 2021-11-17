using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tarve
    {
        public int Tyovuoro_idtyovuoro { get; set; }
        public int Tyotehtava_idtehtava { get; set; }
        public int Maara { get; set; }

        public Tarve()
        {
        }

        public Tarve(int tyovuoro_idtyovuoro, int tyotehtava_idtehtava, int maara) : this()
        {
            Tyovuoro_idtyovuoro = tyovuoro_idtyovuoro;
            Tyotehtava_idtehtava = tyotehtava_idtehtava;
            Maara = maara;
        }
    }
}
