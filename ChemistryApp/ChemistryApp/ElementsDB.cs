﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryApp
{
    class ElementsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename=|DataDirectory|\MMABooks.mdf;" +
                @"Integrated Security=True;" +
                @"Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
