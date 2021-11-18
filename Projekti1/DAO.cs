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

    }
}
