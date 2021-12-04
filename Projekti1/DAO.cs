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
                string sql = "SELECT idtyontekija, etunimi, sukunimi, puhelin, email, nimike, Tyonimike_idnimike FROM Tyontekija t JOIN tyonimike tn ON t.Tyonimike_idnimike = tn.idnimike";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyontekija a = new Tyontekija(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), int.Parse(rdr[6].ToString()));
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
                string sql = "SELECT Tyovuoro_idtyovuoro, alkaa, loppuu, idtehtava, tehtava, paikka, nimike, maara, (SELECT COUNT(k.Tyontekija_idtyontekija) FROM kiinnitys k WHERE k.Tarve_Tyotehtava_idtehtava = t.Tyotehtava_idtehtava AND k.Tarve_Tyovuoro_idtyovuoro = t.Tyovuoro_idtyovuoro) FROM tarve t JOIN tyovuoro tv ON t.Tyovuoro_idtyovuoro = tv.idtyovuoro JOIN tyotehtava tt ON t.Tyotehtava_idtehtava = tt.idtehtava JOIN tyonimike tn ON tt.Tyonimike_idnimike = tn.idnimike";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tarve t = new Tarve(int.Parse(rdr[0].ToString()), DateTime.Parse(rdr[1].ToString()), DateTime.Parse(rdr[2].ToString()), int.Parse(rdr[3].ToString()), rdr[4].ToString(), rdr[5].ToString(),
                        rdr[6].ToString(), int.Parse(rdr[7].ToString()), int.Parse(rdr[8].ToString()));
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

        // Kiinnitysten haku tietokannasta
        public static List<Kiinnitys> GetKiinnitykset()
        {
            List<Kiinnitys> kiinnitykset = new List<Kiinnitys>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT Tyontekija_idtyontekija, Tarve_Tyovuoro_idtyovuoro, Tarve_Tyotehtava_idtehtava, etunimi, sukunimi, nimike FROM kiinnitys k JOIN tyontekija t ON k.Tyontekija_idtyontekija = t.idtyontekija JOIN tyotehtava tt ON k.Tarve_Tyotehtava_idtehtava = tt.idtehtava JOIN tyonimike tn ON tt.Tyonimike_idnimike = tn.idnimike;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Kiinnitys k = new Kiinnitys(int.Parse(rdr[0].ToString()), int.Parse(rdr[1].ToString()), int.Parse(rdr[2].ToString()), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
                    kiinnitykset.Add(k);
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
            return kiinnitykset;
        }

        // Kiinnityksen vieminen tietokantaan
        public static int InsertKiinnitys(Kiinnitys k)
        {

            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO Kiinnitys(Tyontekija_idtyontekija, Tarve_Tyovuoro_idtyovuoro, Tarve_Tyotehtava_idtehtava) VALUES (?Tyontekija_idtyontekija, ?Tarve_Tyovuoro_idtyovuoro, ?Tarve_Tyotehtava_idtehtava)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?Tyontekija_idtyontekija", MySqlDbType.Int32).Value = k.IDtyontekija;
                cmd.Parameters.Add("?Tarve_Tyovuoro_idtyovuoro", MySqlDbType.Int32).Value = k.IDtyovuoro;
                cmd.Parameters.Add("?Tarve_Tyotehtava_idtehtava", MySqlDbType.Int32).Value = k.IDtehtava;


                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Kiinnitys {0}, {1} {2} lisätty", k.IDtyontekija, k.IDtyovuoro, k.IDtehtava);

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

        // Kiinnityksen poistaminen tietokannasta
        public static int DeleteKiinnitys(Kiinnitys k)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "DELETE FROM Kiinnitys WHERE Tyontekija_idtyontekija = ?Tyontekija_idtyontekija AND Tarve_Tyovuoro_idtyovuoro = ?Tarve_Tyovuoro_idtyovuoro AND Tarve_Tyotehtava_idtehtava = ?Tarve_Tyotehtava_idtehtava";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?Tyontekija_idtyontekija", MySqlDbType.Int64).Value = k.IDtyontekija;
                cmd.Parameters.Add("?Tarve_Tyovuoro_idtyovuoro", MySqlDbType.Int64).Value = k.IDtyovuoro;
                cmd.Parameters.Add("?Tarve_Tyotehtava_idtehtava", MySqlDbType.Int64).Value = k.IDtehtava;


                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Kiinnitys poistettu");

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

        //Työnimikkeen lisäys

        public static int InsertTyonimike(Tyonimike tyonimike)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO tyonimike(idnimike, nimike) values (?idnimike, ?nimike)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?idnimike", MySqlDbType.VarChar).Value = tyonimike.Idnimike;
                cmd.Parameters.Add("?nimike", MySqlDbType.VarChar).Value = tyonimike.Nimike;
                

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työnimike {0} {1} lisätty", tyonimike.Idnimike, tyonimike.Nimike);

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

        //Työnimikkeen poisto
        public static int DeleteTyonimike(Tyonimike p)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "DELETE FROM tyonimike WHERE idnimike = ?id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = p.Idnimike;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työnimike id:llä {0} poistettu", p.Idnimike);

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
                string sql = "SELECT idnimike, nimike FROM Tyonimike";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyonimike a = new Tyonimike(int.Parse(rdr[0].ToString()), rdr[1].ToString());
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

        public static List<Tyotehtava> GetTyotehtavat()
        {
            List<Tyotehtava> tyotehtavat = new List<Tyotehtava>();

            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql =
                    "SELECT idtehtava, tehtava, paikka, Tyonimike_idnimike, nimike FROM tyotehtava, tyonimike WHERE Tyonimike_idnimike = idnimike ORDER BY idtehtava";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tyotehtava tt = new Tyotehtava(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), int.Parse(rdr[3].ToString()), (rdr[4].ToString()));
                    tyotehtavat.Add(tt);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
            }
            return tyotehtavat;
        }

        public static int InsertTyotehtava(Tyotehtava tyotehtava)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO  tyotehtava (idtehtava, tehtava, paikka, Tyonimike_idnimike) values (?idtehtava, ?tehtava, ?paikka, ?Tyonimike_idnimike)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?idtehtava", MySqlDbType.VarChar).Value = tyotehtava.Idtyotehtava;
                cmd.Parameters.Add("?tehtava", MySqlDbType.VarChar).Value = tyotehtava.Tehtava;
                cmd.Parameters.Add("?paikka", MySqlDbType.VarChar).Value = tyotehtava.Paikka;
                cmd.Parameters.Add("?Tyonimike_idnimike", MySqlDbType.VarChar).Value = tyotehtava.Tyonimike_idnimike;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("tyotehtava {0} {1} {2} {3} inserted", tyotehtava.Idtyotehtava, tyotehtava.Tehtava, tyotehtava.Paikka, tyotehtava.Tyonimike_idnimike);


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

        public static int UpdateTyotehtava(Tyotehtava tyotehtava)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "UPDATE tyotehtava SET idtehtava = ?idtehtava, tehtava = ?tehtava, paikka = ?paikka, Tyonimike_idnimike = ?Tyonimike_idnimike  WHERE idtehtava = ?idtehtava";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?idtehtava", MySqlDbType.Int64).Value = tyotehtava.Idtyotehtava;
                cmd.Parameters.Add("?tehtava", MySqlDbType.VarChar).Value = tyotehtava.Tehtava;
                cmd.Parameters.Add("?paikka", MySqlDbType.VarChar).Value = tyotehtava.Paikka;
                cmd.Parameters.Add("?Tyonimike_idnimike", MySqlDbType.VarChar).Value = tyotehtava.Tyonimike_idnimike;


                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Tehtävä {0} päivitetty", tyotehtava.Idtyotehtava);

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

        public static int DeleteTyotehtava(Tyotehtava tt)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "DELETE FROM tyotehtava WHERE idtehtava = ?id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = tt.Idtyotehtava;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työtehtävät id:llä {0} poistettu", tt.Idtyotehtava);

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

        public static int InsertTyovuoro(Tyovuoro tyovuoro)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO  tyovuoro (idtyovuoro, alkaa, loppuu) values (?idtyovuoro, ?alkaa, ?loppuu)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?idtyovuoro", MySqlDbType.Int32).Value = tyovuoro.Idtyovuoro;
                cmd.Parameters.Add("?alkaa", MySqlDbType.DateTime).Value = tyovuoro.Alkaa;
                cmd.Parameters.Add("?loppuu", MySqlDbType.DateTime).Value = tyovuoro.Loppuu;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("tyovuoro {0} {1} {2} inserted", tyovuoro.Idtyovuoro, tyovuoro.Alkaa, tyovuoro.Loppuu);

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

        public static int DeleteTyovuoro(Tyovuoro tv)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "DELETE FROM tyovuoro WHERE idtyovuoro = ?id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = tv.Idtyovuoro;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Työvuoro {0} poistettu", tv.Idtyovuoro);

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

        public static int InsertTarve(Tarve tarve)
        {
            int count = 0;
            try
            {
                if (conn == null)
                    conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string sql = "INSERT INTO  tarve (Tyovuoro_idtyovuoro, Tyotehtava_idtehtava, maara) values (?Tyovuoro_idtyovuoro, ?Tyotehtava_idtehtava, ?maara)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("?Tyovuoro_idtyovuoro", MySqlDbType.Int32).Value = tarve.TyovuoroID;
                cmd.Parameters.Add("?Tyotehtava_idtehtava", MySqlDbType.Int32).Value = tarve.TehtavaID;
                cmd.Parameters.Add("?maara", MySqlDbType.Int32).Value = tarve.Maara;

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("tyovuoro {0} {1} {2} inserted", tarve.TyovuoroID, tarve.TehtavaID, tarve.Maara);

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

        //public static int DeleteTarve(Tarve trv)
        //{
        //    int count = 0;
        //    try
        //    {
        //        if (conn == null)
        //            conn = new MySqlConnection();
        //        conn.ConnectionString = myConnectionString;
        //        conn.Open();

        //        string sql = "DELETE FROM tarve WHERE idtyovuoro = ?id";                //miten valitaan tietty tarve?
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);

        //        cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = tv.Idtyovuoro;

        //        count = cmd.ExecuteNonQuery();
        //        if (count > 0)
        //            Console.WriteLine("Työvuoro {0} poistettu", tv.Idtyovuoro);

        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    finally
        //    {
        //        conn.Close();
        //        conn = null;
        //    }
        //    return count;
        //}
    }
}

