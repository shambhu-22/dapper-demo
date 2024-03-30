using TestDapperAPI.Models;

namespace TestDapperAPI.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployeeById(int employeeId);
        public Task<IEnumerable<Employee>> GetEmployeesByCompanyId(int companyId);
    }
}
