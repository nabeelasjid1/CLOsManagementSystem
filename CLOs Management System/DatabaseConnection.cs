using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOs_Management_System
{
    class DatabaseConnection
    {
        public static DatabaseConnection Instance;
        public SqlConnection Connection;
        private DatabaseConnection() { }
        //Singleton Pattern
        public static DatabaseConnection getInstance()
        {
            if(Instance == null)
            {
                Instance = new DatabaseConnection();
            }
            return Instance;
        }
        public SqlConnection getConnection()
        {
            Connection = new SqlConnection(ConnectionString.connection);
            if(Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            return Connection;
        }
        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
