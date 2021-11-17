using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Kiinnitys
    {
        public int Tyontekija_idtyontekija { get; set; }
        public int Tarve_Tyovuoro_idtyovuoro { get; set; }
        public int Tarve_Tyotehtava_idtehtava { get; set; }

        public Kiinnitys()
        {
        }

        public Kiinnitys(int tyontekija_idtyontekija, int tarve_Tyovuoro_idtyovuoro, int tarve_Tyotehtava_idtehtava) : this()
        {
            Tyontekija_idtyontekija = tyontekija_idtyontekija;
            Tarve_Tyovuoro_idtyovuoro = tarve_Tyovuoro_idtyovuoro;
            Tarve_Tyotehtava_idtehtava = tarve_Tyotehtava_idtehtava;
        }
    }
}
