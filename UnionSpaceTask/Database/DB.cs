﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionSpaceTask.Database
{
    public class DB
    {

        readonly MySqlConnection connection = new MySqlConnection("server = us-cdbr-east-06.cleardb.net;username=b5cfe73c3c75ab; password=ea519376; database=heroku_4372dbbd82d8ba8");
        //readonly MySqlConnection connection = new MySqlConnection("server = localhost;username=root;database=product");


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
