using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RGR.Server
{
    public class DB_connect
    {

        private string _conditionString;
        private string _sqlCommentString;

        public string sqlCommandString { get { return _sqlCommentString; } set { _sqlCommentString = value; } }
        public string connectionString { get { return _conditionString; } }

        public DB_connect(string connditon)
        {
            _conditionString = connditon;
        }

        //INSERT, UPDATE, DELETE and other for tables in DB 
        public int DB_Changes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sqlCommentString, connection);
                return command.ExecuteNonQuery();
            }
        }

        //Reading Tables from DB
        public SqlDataReader readTable()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(_sqlCommentString, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //INSERT, UPDATE, DELETE and other for value in DB
        public object DB_ValueChanges()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sqlCommentString, connection);
                return command.ExecuteScalar();
            }
        }


    }
}
