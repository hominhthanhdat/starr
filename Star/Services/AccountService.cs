using Star.Models;

namespace Star.Services
{
    public interface AccountService
    {
        public bool Create(Account account);
        public bool Update(Account account);
        public bool Delete(int id);
        public dynamic FindingById(int id);
        public bool changeStatus(int id);
    }
}
