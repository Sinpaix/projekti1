using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tyontekija
    {
        public int Idtyontekija { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Puhelin { get; set; }
        public string Email { get; set; }
        public int Tyonimike_idnimike { get; set; }

        public Tyontekija()
        {
        }

        public Tyontekija(string etunimi, string sukunimi, string puhelin, string email, int tyonimike_idnimike)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puhelin = puhelin;
            Email = email;
            Tyonimike_idnimike = tyonimike_idnimike;
        }

        public override string ToString()
        {
            return $"{Etunimi}  {Sukunimi}";
        }
    }
}
