using Star.Models;

namespace Star.Services
{
    public interface EmployeeService
    {
        public bool Create(Employee employee);
        public bool Update(Employee employee);
        public bool Delete(int id);
        public bool changeStatus(int id, int status);
        public dynamic FindingAll();
        public dynamic FindingById(int id);
        public dynamic FindingByName(string name);
        public dynamic FindingByService(int service);
        public dynamic FindingByDepartment(int department);
    }
}
