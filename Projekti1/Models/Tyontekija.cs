using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
   public class Tyontekija
    {
        public int Idtyontekija { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Puhelin { get; set; }
        public string Email { get; set; }
        public string Nimike { get; set; }
        public int Tyonimike_idnimike { get; set; }
        public string Tiedot { get; private set; }

        public Tyontekija()
        {
        }

        public Tyontekija(string etunimi, string sukunimi, string puhelin, string email, int tyonimike_idnimike) : this()
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puhelin = puhelin;
            Email = email;
            Tyonimike_idnimike = tyonimike_idnimike;
            Tiedot = $"{Etunimi} {Sukunimi}, {Nimike}";
        }

        public Tyontekija(int idtyontekija, string etunimi, string sukunimi, string puhelin, string email, string nimike, int tyonimike_idnimike) : this()
        {
            Idtyontekija = idtyontekija;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puhelin = puhelin;
            Email = email;
            Nimike = nimike;
            Tyonimike_idnimike = tyonimike_idnimike;
            Tiedot = $"{Etunimi} {Sukunimi}, {Nimike}";
        }

        
        public override string ToString()
        {
            return $"{Etunimi}  {Sukunimi}";
        }
        
    }
}
