using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Kiinnitys
    {
        public int IDtyontekija { get; set; }
        public int IDtyovuoro { get; set; }
        public int IDtehtava { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Nimike { get; set; }

        public Kiinnitys()
        {
        }

        public Kiinnitys(int iDtyontekija, int iDtyovuoro, int iDtehtava, string etunimi, string sukunimi, string nimike) : this()
        {
            IDtyontekija = iDtyontekija;
            IDtyovuoro = iDtyovuoro;
            IDtehtava = iDtehtava;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Nimike = nimike;
        }


    }
}
