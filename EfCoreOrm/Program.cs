using efcoreOrm.Data;

namespace efcoreOrm;

class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();
        #region Reading
        var data = context.Wallets; // dbset type 
        foreach (var item in data)
        {
            // Console.WriteLine(item);
        }
        #endregion

        #region Inserting

        context.Wallets.Add(new Wallets { Balance = 50,Holder = "req"});
        context.SaveChanges();

        #endregion

        #region Update

        var wallet = context.Wallets.Single(x => x.Id == 2);
        if (wallet != null)
        {
            wallet.Balance -= 100;
        }

        context.SaveChanges();

        #endregion
        
        #region Delete

        var walletToDelete = context.Wallets.Single(x => x.Id == 2);
        if (walletToDelete != null)
        {
            context.Remove(walletToDelete);
        }
        context.SaveChanges();

        #endregion

        #region Transaction

        var transaction = context.Database.BeginTransaction();
        var walletTo = context.Wallets.Single(x => x.Id == 4);
        var walletFrom = context.Wallets.Single(x => x.Id == 3);
        if (walletTo != null && walletFrom != null)
        {
            walletTo.Balance += 50;
            context.SaveChanges();
            walletFrom.Balance -= 50;
            context.SaveChanges();
            transaction.Commit();
        }
        transaction.Rollback();
    
        #endregion
    }
}