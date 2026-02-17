using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryManagementSystem_2
{
    public class Context
    {
        public SqlConnection Baglanti()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbLibrarySystem;Integrated Security=True;");

            return connect;
        }
       
    }
}
