using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public interface ClientService
    {
        public dynamic FindAll();
        public dynamic Find(int id);
        public bool Create(Client client);
        public bool Update(Client client);
        public bool Delete(int id);
    }
}
