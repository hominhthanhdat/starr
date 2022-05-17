using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public interface BusinessService
    {
        public dynamic FindAll();
        public dynamic Find(int id);
        public bool Create(Business business);
        public bool Update(Business business);
        public bool Delete(int id);
        public bool UpdateStatus(int id);
    }
}
