using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public class ClientServiceImpl : ClientService
    {
        private DatabaseContext db;
        public ClientServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public dynamic FindAll()
        {
            return db.Clients
                .Select(c => new
                {
                    ClientId = c.ClientId,
                    NameClient = c.NameClient,
                    AddressClient = c.AddressClient,
                    EmailClient = c.EmailClient,
                    PhoneClient = c.PhoneClient,
                }).ToList();
        }
        public dynamic Find(int id)
        {
            return db.Clients.Select(c => new
            {
                ClientId = c.ClientId,
                NameClient = c.NameClient,
                AddressClient = c.AddressClient,
                EmailClient = c.EmailClient,
                PhoneClient = c.PhoneClient,
            }).FirstOrDefault();
        }

        public bool Create(Client client)
        {
            try
            {
                db.Clients.Add(client);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Client client)
        {
            try
            {
                db.Entry(client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                db.Clients.Remove(db.Clients.Find(id));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
