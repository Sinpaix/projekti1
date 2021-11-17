﻿using System;
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
        public int Nimike_idnimike { get; set; }

        public Tyontekija()
        {
        }

        public Tyontekija(string etunimi, string sukunimi, string puhelin, string email, int nimike_idnimike)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puhelin = puhelin;
            Email = email;
            Nimike_idnimike = nimike_idnimike;
        }
    }
}
