using DataModel.Models;

namespace WebApi.Infrastructure.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {

        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployees(int id);
        Task<Employee> AddEmployees(Employee employee);
        Task<Employee> UpdateEmployees(Employee employee);
        Task<Employee> DeleteEmployees(int id);
        Task<IEnumerable<Employee>> Search(string name);

    }
}
