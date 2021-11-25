using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tyotehtava
    {
        public int Idtyotehtava { get; set; }
        public DateTime Alkaa { get; set; }
        public DateTime Loppuu { get; set; }
        public int Idtyovuoro { get; set; }
        public string Tehtava { get; set; }
        public string Paikka { get; set; }
        public int Tyonimike_idnimike { get; set; }
        public string Nimike { get; set; }
        public int Maara { get; set; }

        public Tyotehtava()
        {
        }

        public Tyotehtava(int idtyotehtava, string tehtava, string paikka, int tyonimike_idnimike, string nimike)
        {
            Idtyotehtava = idtyotehtava;
            Tehtava = tehtava;
            Paikka = paikka;
            Tyonimike_idnimike = tyonimike_idnimike;
            Nimike = nimike;
        }

        public Tyotehtava(int idtyotehtava, string tehtava, string paikka, string nimike)
        {
            Idtyotehtava = idtyotehtava;
            Tehtava = tehtava;
            Paikka = paikka;
            Nimike = nimike;
        }

        public Tyotehtava(int idtyotehtava, DateTime alkaa, DateTime loppuu, int idtyovuoro, string tehtava, string paikka, int tyonimike_idnimike, string nimike, int maara)
        {
            Idtyotehtava = idtyotehtava;
            Alkaa = alkaa;
            Loppuu = loppuu;
            Idtyovuoro = idtyovuoro;
            Tehtava = tehtava;
            Paikka = paikka;
            Tyonimike_idnimike = tyonimike_idnimike;
            Nimike = nimike;
            Maara = maara;
        }
    }
}
