using Star.Models;

namespace Star.Services
{
    public class AccountServiceImplement : AccountService
    {
        private DatabaseContext db;
        public AccountServiceImplement(DatabaseContext _db) {
            db = _db;
        }
        public bool changeStatus(int id)
        {
            try
            {
                var account = db.Accounts.Find(id);
                account.StatusAccount = !account.StatusAccount;
                db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
       
        }

        public bool Create(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                db.Accounts.Remove(db.Accounts.Find(id));
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public dynamic FindingById(int id)
        {
            return db.Accounts.Select(x=> new
            {
                x.EmployeeId,
                x.UserName,
                x.Password,
                x.RoleAccount,
                x.Email,
                x.StatusAccount
            })
                .FirstOrDefault(x => x.EmployeeId == id);
        }

        public bool Update(Account account)
        {
            try
            {
                db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
