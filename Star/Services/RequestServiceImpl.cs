using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public class RequestServiceImpl : RequestService
    {
        private DatabaseContext db;
        public RequestServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public dynamic FindAll()
        {
            return db.Requests
                .Where(r => r.StatusRequest == 0)
                .Select(r => new
            {
                RequestId = r.RequestId,
                IdentifyClient = r.IdentifyClient,
                StatusRequest = r.StatusRequest,
                NameClient = r.NameClient,
                AddressClient = r.AddressClient,
                EmailClient = r.EmailClient,
                PhoneClient = r.PhoneClient,
                BusinessId = r.BusinessId,
            }).ToList();
        }
        public dynamic Find(int id)
        {
            return db.Requests
                .Where(r => r.RequestId == id)
                .Select(r => new
                {
                    RequestId = r.RequestId,
                    IdentifyClient = r.IdentifyClient,
                    StatusRequest = r.StatusRequest,
                    NameClient = r.NameClient,
                    AddressClient = r.AddressClient,
                    EmailClient = r.EmailClient,
                    PhoneClient = r.PhoneClient,
                    BusinessId = r.BusinessId,
                })
                .FirstOrDefault();
        }
        public bool Create(Request request)
        {
            try
            {
                db.Requests.Add(request);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStatus(int id, short status)
        {
            try
            {
                var request = db.Requests.Find(id);
                request.StatusRequest = Convert.ToInt16(status);
                db.Entry(request).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Request request)
        {
            try
            {
                db.Entry(request).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                db.Requests.Remove(db.Requests.Find(id));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
