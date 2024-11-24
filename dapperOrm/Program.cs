using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using ado;
using Dapper;

namespace dapperOrm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build() ;
            IDbConnection dbConnection = new SqlConnection(config.GetSection("ConnectionStrings").Value) ;

            #region Reading
            var sql = "select * from Wallets";

            // Console.WriteLine("------------------ using Dynamic Type ----------------------");
            var resultDynamic = dbConnection.Query(sql);
            foreach (var item in resultDynamic)
            {
                // Console.WriteLine(item);
            }
            // Console.WriteLine("------------------ using Static Type ----------------------");
            var resultStatic = dbConnection.Query<Wallets>(sql);
            foreach (var item in resultStatic)
            {
                // Console.WriteLine(item);
            }

            #endregion
            
            #region Inserting
            var insertedWallet = new Wallets() { Balance = 5000, Holder = "Amr" };

            // setting sql command
            var sqlInsertion = "insert into Wallets (Holder,Balance) values" + $"(@Holder , @Balance)" ;
            
            // dbConnection.Execute(sqlInsertion, insertedWallet);
            #endregion
            
            #region Updating
            var sqlUpdating = "update Wallets set Holder=@Holder ,Balance=@Balance where Id = @Id";
            // dbConnection.Execute(sqlUpdating, new{Holder="Ahmed", Balance=10000 , id=1});
            #endregion
            
            #region Deleting
            var sqlDeleting = "delete from Wallets where Id = @Id";
            // dbConnection.Execute(sqlDeleting, new{Id = 1});
            #endregion

            #region MultiQuery
            var multisql = "select Min(Balance) from Wallets; select Max(Balance) from Wallets;";
            var res = dbConnection.QueryMultiple(multisql);
            Console.WriteLine($"Min is {res.ReadSingle<int>()} , Max is {res.ReadSingle<int>()}");

            #endregion
        }
    }
}
