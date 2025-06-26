using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrustructure.Repositories
{
    public class GenericRepository
    {
        public void ExecuteSP(string spName,string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", "John");
                    cmd.Parameters.AddWithValue("@LastName", "Doe");
                    cmd.Parameters.AddWithValue("@Email", "john.doe@example.com");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
    }
}
