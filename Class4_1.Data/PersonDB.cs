using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Class4_1.Data
{
    public class PersonDB
    {
        private string _connectionString;
        public PersonDB(string conn)
        {
            _connectionString = conn;
        }

        public void AddPerson(Person p)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"Insert Into Person (FirstName, LastName, Age)
                                      Values (@first, @last, @age)";
                cmd.Parameters.AddWithValue("@last", p.LastName);
                cmd.Parameters.AddWithValue("@age", p.Age);
                cmd.Open();
            }

        }
    }
}
