using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public interface RequestService
    {
        public dynamic FindAll();
        public dynamic Find(int id);
        public bool Create(Request request);
        public bool Update(Request request);
        public bool UpdateStatus(int id, short status);
        public bool Delete(int id);
    }
}
