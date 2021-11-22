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

        public int RemoveTyontekija(Tyontekija a)
        {
            return DAO.DeleteTyontekija(a);
        }

        public int AddTyontekija(Tyontekija a)
        {
            return DAO.InsertTyontekija(a);
        }

        public int EditTyontekija(Tyontekija a)
        {
            return DAO.UpdateTyontekija(a);
        }

        public List<Tyonimike> LoadTyonimikkeet()
        {
            return DAO.GetTyonimikkeet();
        }

        //Tyotehtävät
        public List<Tyotehtava> LoadTyotehtavat()
        {
            return DAO.GetTyotehtavat();
        }
    }
}
