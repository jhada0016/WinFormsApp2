using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    internal class DataBase
    {

        public static MySqlConnection GetConnection()
        {
            string conString = "server=localhost;database=sarisari_db;uid=root;pwd=;";

            MySqlConnection con = new MySqlConnection(conString);

            return con;
        }
    }

}
