using Star.Models;

namespace Star.Services
{
    public interface DepartmentService
    {
        public dynamic GetAll();
        public bool Create(Department department);
        public bool Update(Department department);
        public bool changeStatus(int id);
    }
}
