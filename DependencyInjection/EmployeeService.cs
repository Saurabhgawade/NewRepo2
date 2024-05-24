using DependencyInjection.Models;

namespace DependencyInjection
{
    public class EmployeeService:IEmployee
    {
        List<Employee> employeeList = new List<Employee>() { new Employee() { Id = 1, Name = "saurabh" }, new Employee() { Id = 2, Name = "suraj" } };

        public List<Employee> getAllEmployee()
        {
            var result = employeeList.Where(x => true).ToList();
            return result;
        }

        public Employee getById(int id)
        {
            var result = employeeList.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }
    }
}
