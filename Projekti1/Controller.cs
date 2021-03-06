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


        // Tarve
        public List<Tarve> LataaTarpeet()
        {
            return DAO.GetTarpeet();
        }

        public int AddTarve(Tarve tr)
        {
            return DAO.InsertTarve(tr);
        }

        public int RemoveTarve(Tarve trv)
        {
            return DAO.DeleteTarve(trv);
        }

        // Kiinnitykset
        public List<Kiinnitys> LataaKiinnitykset()
        {
            return DAO.GetKiinnitykset();
        }

        public int LisaaKiinnitys(Kiinnitys k)
        {
            return DAO.InsertKiinnitys(k);
        }

        public int PoistaKiinnitys(Kiinnitys k)
        {
            return DAO.DeleteKiinnitys(k);
        }

        // Tyovuorot
        public List<Tyovuoro> LataaTyovuorot()
        {
            return DAO.GetTyovuorot();
        }

        public int AddTyovuoro(Tyovuoro tv)
        {
            return DAO.InsertTyovuoro(tv);
        }

        public int RemoveTyovuoro(Tyovuoro tv)
        {
            return DAO.DeleteTyovuoro(tv);
        }


        //työnimikkeet
        public List<Tyonimike> LoadTyonimikkeet()
        {
            return DAO.GetTyonimikkeet();
        }

        public int AddTyonimike(Tyonimike tn)
        {
            return DAO.InsertTyonimike(tn);
        }

        public int RemoveTyonimike(Tyonimike a)
        {
            return DAO.DeleteTyonimike(a);
        }

        //Tyotehtävät
        public List<Tyotehtava> LoadTyotehtavat()
        {
            return DAO.GetTyotehtavat();
        }

        public int AddTyotehtava(Tyotehtava tt)
        {
            return DAO.InsertTyotehtava(tt); 
        }
       
        public int RemoveTyotehtava(Tyotehtava tt)
        {
            return DAO.DeleteTyotehtava(tt);
        }

        public int EditTyotehtava(Tyotehtava tt)
        {
            return DAO.UpdateTyotehtava(tt);
        }

        //työvuorolista
        public List<Tarve> LoadVuorolista(DateTime alku, DateTime loppu)
        {
            return DAO.GetVuorolista(alku, loppu);
        }

        //vapaalista
        public List<Tarve> LoadVapaalista(DateTime valku, DateTime vloppu)
        {
            return DAO.GetVapaalista(valku, vloppu);
        }
    }
}
