using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Configurations = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            //setting up connection
            SqlConnection conn = new SqlConnection(Configurations.GetSection("ConnectionStrings").Value);


            #region Reading
            // setting the command
            var sql = "select * from Wallets";
            SqlCommand command = new SqlCommand(sql, conn);
            command.CommandType = CommandType.Text;

            // sending the query to db
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            Wallets wallet;
            while (reader.Read())
            {
                wallet = new Wallets()
                {
                    Id = reader.GetInt32("Id"),
                    Holder = reader.GetString("Holder"),
                    Balance = reader.GetDecimal("Balance")
                };
                //Console.WriteLine(wallet);
            }
            conn.Close();
            #endregion

            #region Inserting
            var insertedWallet = new Wallets() { Balance = 5000, Holder = "Amr" };

            // setting sql command
            var sqlInsertion = "insert into Wallets (Holder,Balance) values" + $"(@Holder , @Balance)" + $"select CAST(scope_identity() as int)";

            SqlParameter Holderparam = new SqlParameter
            {
                ParameterName = "@Holder",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = insertedWallet.Holder
            };

            SqlParameter Balanceparam = new SqlParameter
            {
                ParameterName = "@Balance",
                SqlDbType = SqlDbType.Decimal,
                Direction = ParameterDirection.Input,
                Value = insertedWallet.Balance
            };


            SqlCommand command1 = new SqlCommand(sqlInsertion, conn);
            command1.Parameters.Add(Holderparam);
            command1.Parameters.Add(Balanceparam);
            command1.CommandType = CommandType.Text;

            // Sending Query
            conn.Open();
            // non-query
            //if (command1.ExecuteNonQuery() > 0) Console.WriteLine("Inserted Successfully");
            //else Console.WriteLine("Failed To Insert");

            // scaler
            //insertedWallet.Id = (int)command1.ExecuteScalar();
            //Console.WriteLine(insertedWallet.Id);
            conn.Close();


            #endregion

            #region Updating
            // setting sql command
            var sqlUpdating = "update Wallets set Holder=@Holder ,Balance=@Balance where Id = @Id";

            SqlParameter HolderparamUpdate = new SqlParameter
            {
                ParameterName = "@Holder",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Ahhmmeedd"
            };

            SqlParameter BalanceparamUpdate = new SqlParameter
            {
                ParameterName = "@Balance",
                SqlDbType = SqlDbType.Decimal,
                Direction = ParameterDirection.Input,
                Value = 11
            };
            SqlParameter IdparamUpdate = new SqlParameter
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = 1
            };


            SqlCommand command2 = new SqlCommand(sqlUpdating, conn);
            command2.Parameters.Add(HolderparamUpdate);
            command2.Parameters.Add(BalanceparamUpdate);
            command2.Parameters.Add(IdparamUpdate);
            command2.CommandType = CommandType.Text;

            // Sending Query
            conn.Open();
            // non-query
            //if (command2.ExecuteNonQuery() > 0) Console.WriteLine("Updated Successfully");
            //else Console.WriteLine("Failed To Update");

            conn.Close();
            #endregion

            #region Deleting
            // setting sql command
            var sqlDeleting = "delete from Wallets where Id = @Id";
            ;
            SqlParameter IdparamDelete = new SqlParameter
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = 1
            };

            SqlCommand command3 = new SqlCommand(sqlDeleting, conn);
            command3.Parameters.Add(IdparamDelete);
            command3.CommandType = CommandType.Text;

            // Sending Query
            conn.Open();
            // non-query
            //if (command3.ExecuteNonQuery() > 0) Console.WriteLine("Deleted Successfully");
            //else Console.WriteLine("Failed To Delete");

            conn.Close();
            #endregion

            #region Disconnected Mode
            var sqlDisCommand = "select * from Wallets";

            SqlDataAdapter Sadapter = new SqlDataAdapter(sqlDisCommand, conn);
            DataTable DT = new DataTable();
            Sadapter.Fill(DT);


            foreach (DataRow row in DT.Rows)
            {
                var newWallet = new Wallets
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Holder = (string)(row["Holder"]),
                    Balance = Convert.ToDecimal(row["Balance"]),
                };
                Console.WriteLine(newWallet);
            }
            #endregion

            #region Transactions
            SqlCommand command4 = conn.CreateCommand();
            command4.CommandType = CommandType.Text;

            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            command4.Transaction = trans;
            try
            {
                command4.CommandText = "update Wallets set Balance = balance-100 where Id=2";
                command4.ExecuteNonQuery();

                command4.CommandText = "update Wallets set Balance = balance+100 where Id=3";
                command4.ExecuteNonQuery();

                trans.Commit();
                Console.WriteLine("Transaction commited");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                Console.WriteLine("Transaction Rolled Back");
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }
    }
}
