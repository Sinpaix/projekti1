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
                string sql = "SELECT idtyontekija, etunimi, sukunimi, puhelin, email, tyonimike_idnimike FROM Tyontekija";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyontekija a = new Tyontekija(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), int.Parse(rdr[5].ToString()));
                    tyontekijat.Add(a);
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
    

        // Työvuorotarpeiden haku tietokannasta
        public static List<Tarve> GetTarpeet()
        {
            List<Tarve> tarpeet = new List<Tarve>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT Tyovuoro_idtyovuoro, Tyotehtava_idtehtava, maara FROM tarve";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tarve t = new Tarve(int.Parse(rdr[0].ToString()), int.Parse(rdr[1].ToString()), int.Parse(rdr[2].ToString()));
                    tarpeet.Add(t);
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
            return tarpeet;
        }

        // Työvuorojen haku tietokannasta
        public static List<Tyovuoro> GetTyovuorot()
        {
            List<Tyovuoro> tyovuorot = new List<Tyovuoro>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT idtyovuoro, alkaa, loppuu FROM tyovuoro";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyovuoro t = new Tyovuoro(int.Parse(rdr[0].ToString()), DateTime.Parse(rdr[1].ToString()), DateTime.Parse(rdr[2].ToString()));
                    tyovuorot.Add(t);
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
            return tyovuorot;
        }

        // työntekijän lisäys
        public static int InsertTyontekija(Tyontekija tyontekija)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO Tyontekija(etunimi, sukunimi, puhelin, email, tyonimike_idnimike) values (?etunimi, ?sukunimi, ?puhelin, ?email, ?tyonimike_idnimike)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?etunimi", MySqlDbType.VarChar).Value = tyontekija.Etunimi;
                cmd.Parameters.Add("?sukunimi", MySqlDbType.VarChar).Value = tyontekija.Sukunimi;
                cmd.Parameters.Add("?puhelin", MySqlDbType.VarChar).Value = tyontekija.Puhelin;
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = tyontekija.Email;
                cmd.Parameters.Add("?tyonimike_idnimike", MySqlDbType.Int64).Value = tyontekija.Tyonimike_idnimike;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työntekijä {0} {1} lisätty", tyontekija.Etunimi, tyontekija.Sukunimi);

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
            return count;
        }

        // työntekijän päivitys
        public static int UpdateTyontekija(Tyontekija tyontekija)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "UPDATE Tyontekija SET etunimi = ?etunimi, sukunimi = ?sukunimi, puhelin = ?puhelin, email = ?email, tyonimike_idnimike = ?tyonimike_idnimike WHERE idtyontekija = ?id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = tyontekija.Idtyontekija;
                cmd.Parameters.Add("?etunimi", MySqlDbType.VarChar).Value = tyontekija.Etunimi;
                cmd.Parameters.Add("?sukunimi", MySqlDbType.VarChar).Value = tyontekija.Sukunimi;
                cmd.Parameters.Add("?puhelin", MySqlDbType.VarChar).Value = tyontekija.Puhelin;
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = tyontekija.Email;
                cmd.Parameters.Add("?tyonimike_idnimike", MySqlDbType.Int64).Value = tyontekija.Tyonimike_idnimike;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työntekijä {0} päivitetty", tyontekija.Idtyontekija);

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
            return count;
        }

        public static int DeleteTyontekija(Tyontekija a)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "DELETE FROM Tyontekija WHERE idtyontekija = ?id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = a.Idtyontekija;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työntekijät id:llä {0} poistettu", a.Idtyontekija);

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
            return count;
        }

        // työnimikkeiden haku
        public static List<Tyonimike> GetTyonimikkeet()
        {
            List<Tyonimike> tyonimikkeet = new List<Tyonimike>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT nimike FROM Tyonimike";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyonimike a = new Tyonimike(rdr[0].ToString());
                    tyonimikkeet.Add(a);
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
            return tyonimikkeet;
        }
    }
}

