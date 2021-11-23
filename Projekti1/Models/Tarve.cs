using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tarve
    {
        public int TyovuoroID { get; set; }
        public DateTime Alkaa { get; set; }
        public DateTime Loppuu { get; set; }
        public string Tehtava { get; set; }
        public string Paikka { get; set; }
        public string Nimike { get; set; }
        public int Maara { get; set; }

        public Tarve()
        {
        }

        public Tarve(int tyovuoroID, DateTime alkaa, DateTime loppuu, string tehtava, string paikka, string nimike, int maara) : this()
        {
            TyovuoroID = tyovuoroID;
            Alkaa = alkaa;
            Loppuu = loppuu;
            Tehtava = tehtava;
            Paikka = paikka;
            Nimike = nimike;
            Maara = maara;
        }
    }
}
