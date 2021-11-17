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
        public string Tehtava { get; set; }
        public string Paikka { get; set; }
        public int Tyonimike_idnimike { get; set; }

        public Tyotehtava()
        {
        }

        public Tyotehtava(string tehtava, string paikka, int tyonimike_idnimike) : this()
        {
            Tehtava = tehtava;
            Paikka = paikka;
            Tyonimike_idnimike = tyonimike_idnimike;
        }
    }
}
