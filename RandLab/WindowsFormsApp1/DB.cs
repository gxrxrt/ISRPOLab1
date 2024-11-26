﻿using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = up_4k");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
