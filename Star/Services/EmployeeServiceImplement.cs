using Star.Models;

namespace Star.Services
{
    public class EmployeeServiceImplement : EmployeeService
    {
        private DatabaseContext db;
        public EmployeeServiceImplement(DatabaseContext _db)
        {
            db = _db;
        }

        public bool changeStatus(int id, int status)
        {
            try
            {
                var employee = db.Employees.Find(id);
                employee.StatusEmployee = Convert.ToInt16(status);
                db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        public bool Create(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                //db.Employees.Remove(db.Employee.Find(id));
                //return db.SaveChanges() > 0;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public dynamic FindingAll()
        {
            
            return db.Employees
                .Select(x => new
            {
                    x.EmployeeId,
                    x.FullName,
                    x.BusinessId,
                    x.PhoneNumber,
                    x.Achievement,
                    x.AddressEmployee,
                    x.PhotoEmployee,
                    x.DepartmentId,
                    x.QualityEducation,
                    x.StatusEmployee,
                    x.Grade,
                    x.RoleEmployee
            })
                .ToList();
        }

        public dynamic FindingByDepartment(int department)
        {
            return db.Employees.Select(x => new
            {
                x.EmployeeId,
                x.FullName,
                x.BusinessId,
                x.PhoneNumber,
                x.Achievement,
                x.AddressEmployee,
                x.PhotoEmployee,
                x.DepartmentId,
                x.QualityEducation,
                x.StatusEmployee,
                x.Grade,
                x.RoleEmployee
            }).Where(x => x.DepartmentId == department).ToList();

        }

        public dynamic FindingById(int id)
        {
            return db.Employees.Select(x => new
            {
                x.EmployeeId,
                x.FullName,
                x.BusinessId,
                x.PhoneNumber,
                x.Achievement,
                x.AddressEmployee,
                x.PhotoEmployee,
                x.DepartmentId,
                x.QualityEducation,
                x.StatusEmployee,
                x.Grade,
                x.RoleEmployee

            }).FirstOrDefault(x => x.EmployeeId == id);
            
        }

        public dynamic FindingByName(string name)
        {
            return db.Employees.Where(x => x.FullName.ToLower().Contains(name.ToLower())).Select(x => new
            {
                x.EmployeeId,
                x.FullName,
                x.BusinessId,
                x.PhoneNumber,
                x.Achievement,
                x.AddressEmployee,
                x.PhotoEmployee,
                x.DepartmentId,
                x.QualityEducation,
                x.StatusEmployee,
                x.Grade,
                x.RoleEmployee

            }).ToList();
           
        }

        public dynamic FindingByService(int service)
        {
            return db.Employees.Where(x => x.BusinessId == service).Select(x => new
            {
                x.EmployeeId,
                x.FullName,
                x.BusinessId,
                x.PhoneNumber,
                x.Achievement,
                x.AddressEmployee,
                x.PhotoEmployee,
                x.DepartmentId,
                x.QualityEducation,
                x.StatusEmployee,
                x.Grade,
                x.RoleEmployee
            }).ToList();
            
        }

        public bool Update(Employee employee)
        {
            try
            {
                db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
