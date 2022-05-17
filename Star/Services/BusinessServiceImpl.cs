using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public class BusinessServiceImpl : BusinessService
    {
        private DatabaseContext db;
        public BusinessServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public dynamic FindAll()
        {
            return db.Businesses
                .Where(b => b.StatusBusiness == true)
                .Select(b => new
                {
                    BusinessId = b.BusinessId,
                    NameBusiness = b.NameBusiness,
                    DescriptionBusiness = b.DescriptionBusiness,
                    Duration = b.Duration,
                    PhotoBusiness = b.PhotoBusiness,
                    StatusBusiness = b.StatusBusiness,
                    CategoryId = b.CategoryId,
                }).ToList();
        }
        public dynamic Find(int id)
        {
            return db.Businesses.Where(x => x.BusinessId == id).Select(b => new
            {
                BusinessId = b.BusinessId,
                NameBusiness = b.NameBusiness,
                DescriptionBusiness = b.DescriptionBusiness,
                Duration = b.Duration,
                PhotoBusiness = b.PhotoBusiness,
                StatusBusiness = b.StatusBusiness,
                CategoryId = b.CategoryId,
            }).FirstOrDefault();
        }

        public bool Create(Business business)
        {
            try
            {
                db.Businesses.Add(business);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Business business)
        {
            try
            {
                db.Entry(business).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                db.Businesses.Remove(db.Businesses.Find(id));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStatus(int id)
        {
            try
            {
                var business = db.Businesses.Find(id);
                business.StatusBusiness = !business.StatusBusiness;
                db.Entry(business).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
