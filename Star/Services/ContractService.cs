using Star.Models;

namespace Star.Services
{
    public interface ContractService
    {
        public bool Create(Contract contract);
        public bool Update(Contract contract);
        public bool Delete(int id);
        public dynamic FindingByIdClient(int id);
        public dynamic FindingByIdEmployee(int id);
        public bool changeStatus(int id,int status);
    }
}
