using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti1.Models
{
    class Tyonimike
    {
        public int Idnimike { get; set; }
        public string Nimike { get; set; }

        public Tyonimike()
        {
        }

        public Tyonimike(int idnimike, string nimike) : this()
        {
            Idnimike = idnimike;
            Nimike = nimike;
        }
    }
}
