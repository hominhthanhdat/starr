using Star.Models;

namespace Star.Services
{
    public class DepartmentServiceImplement : DepartmentService
    {
        private DatabaseContext db;
        public DepartmentServiceImplement(DatabaseContext _db)
        {
            db = _db;
        }
        public bool changeStatus(int id)
        {
            try
            {
                var department = db.Departments.Find(id);
                department.StatusDepartment = !department.StatusDepartment;
                db.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
         
        }

        public bool Create(Department department)
        {
            try
            {
                db.Departments.Add(department);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public dynamic GetAll()
        {
            return db.Departments.ToList();

        }

        public bool Update(Department department)
        {
            try
            {
                db.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
