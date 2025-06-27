using AMS.Core.Entities;
using AMS.Core.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrustructure.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        public const string spName = "sp_ManageChartOfAccounts";
        public const string connectionString = "Server=.\\SQLEXPRESS;Database=ams;User Id=qtec;Password=123456;Trust Server Certificate=True;";
        public void ExecuteAccountInsertSP(Account account)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@Id", account?.Id);
                    cmd.Parameters.AddWithValue("@Name", account?.Name);
                    cmd.Parameters.AddWithValue("@UserType", account?.UserType);
                    cmd.Parameters.AddWithValue("@Cash", account?.Cash);
                    cmd.Parameters.AddWithValue("@ParentAccountId", account?.ParentAccountId);
                    cmd.Parameters.AddWithValue("@AccountType", account?.AccountType);
                    cmd.Parameters.AddWithValue("@Recieveable", account?.Recieveable);

                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw ;
                    }
                }
            }
        }

    }
}
