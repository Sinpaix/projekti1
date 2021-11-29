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
        public int TehtavaID { get; set; }
        public string Tehtava { get; set; }
        public string Paikka { get; set; }
        public string Nimike { get; set; }
        public int Maara { get; set; }

        public Tarve()
        {
        }

        public Tarve(int tyovuoroID, DateTime alkaa, DateTime loppuu, int tehtavaID, string tehtava, string paikka, string nimike, int maara) : this()
        {
            TyovuoroID = tyovuoroID;
            Alkaa = alkaa;
            Loppuu = loppuu;
            TehtavaID = tehtavaID;
            Tehtava = tehtava;
            Paikka = paikka;
            Nimike = nimike;
            Maara = maara;
        }

        public Tarve(int tyovuoroID, int tehtavaID, int maara)
        {
            TyovuoroID = tyovuoroID;
            TehtavaID = tehtavaID;
            Maara = maara;
        }
    }
}
