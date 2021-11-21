using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekti1.Models;

namespace Projekti1
{
    class Controller
    {
        // Työntekijä
        public List<Tyontekija> LataaTyontekijat()
        {
            return DAO.GetTyontekijat();
        }


        // Tarve
        public List<Tarve> LataaTarpeet()
        {
            return DAO.GetTarpeet();
        }

        // Tyovuorot
        public List<Tyovuoro> LataaTyovuorot()
        {
            return DAO.GetTyovuorot();
        }
    }
}
