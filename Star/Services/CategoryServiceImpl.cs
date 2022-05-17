using Practice02_WebAPI.Models;

namespace Practice02_WebAPI.Services
{
    public class CategoryServiceImpl : CategoryService
    {
        private DatabaseContext db;
        public CategoryServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public dynamic FindAll()
        {
            return db.CategoryBusinesses.Select(c => new
            {
                CategoryId = c.CategoryId,
                NameCategory = c.NameCategory,
                DescriptionCategory = c.DescriptionCategory,
            }).ToList();
        }
    }
}
