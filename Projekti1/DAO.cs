using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekti1.Models;
using MySql.Data.MySqlClient;

namespace Projekti1
{
    class DAO
    {
        static MySqlConnection conn = null;
        static string myConnectionString = "server=127.0.0.1;uid=root;" +
             "pwd=root;database=sairaalakanta";

        // Työntekijöiden hakeminen tietokannasta
        public static List<Tyontekija> GetTyontekijat()
        {
            List<Tyontekija> tyontekijat = new List<Tyontekija>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT etunimi, sukunimi, puhelin, email, Tyonimike_idnimike FROM tyontekija";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyontekija t = new Tyontekija(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), int.Parse(rdr[4].ToString()));
                    tyontekijat.Add(t);
                }
                rdr.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
            }
            return tyontekijat;
        }

    }
}
