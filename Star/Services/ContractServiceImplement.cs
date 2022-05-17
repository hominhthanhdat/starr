using Star.Models;

namespace Star.Services
{
    public class ContractServiceImplement : ContractService
    {
        private DatabaseContext db;
        public ContractServiceImplement(DatabaseContext _db)
        {
            db = _db;
        }
        public bool changeStatus(int id, int status)
        {
            try
            {
                var contract = db.Contracts.Find(id);
                contract.StatusContract = Convert.ToInt16(status);
                db.Entry(contract).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Create(Contract contract)
        {
            try
            {
                db.Contracts.Add(contract);
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
                db.Contracts.Remove(db.Contracts.Find(id));
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public dynamic FindingByIdClient(int id)
        {
            return db.Contracts.Where(x => x.ClientId == id);
        }

        public dynamic FindingByIdEmployee(int id)
        {
            return db.Contracts.Where(x => x.EmployeeId == id);

           
        }

        public bool Update(Contract contract)
        {
            try
            {
                db.Entry(contract).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
