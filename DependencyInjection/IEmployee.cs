using DependencyInjection.Models;

namespace DependencyInjection
{
    public interface IEmployee
    {
        List<Employee> getAllEmployee();
        Employee getById(int id);
    }
}
