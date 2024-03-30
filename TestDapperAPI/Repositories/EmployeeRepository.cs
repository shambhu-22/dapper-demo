using Dapper;
using TestDapperAPI.Data;
using TestDapperAPI.Models;

namespace TestDapperAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _dapperContext;
        public EmployeeRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        /// <summary>
        /// Returns Employee list of a company based on it's company Id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Employee>> GetEmployeesByCompanyId(int companyId)
        {
            var query = "Select * from Employees where CompanyId = @Id";
            using(var connection = _dapperContext.CreateConnection())
            {
                var employees = await connection.QueryAsync<Employee>(query, companyId);
                return employees.ToList();
            }
        }

        /// <summary>
        /// Returns an employee with an Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeById(int id)
        {
            var query = "Select * from Employees where Id = @Id";
            using(var connection = _dapperContext.CreateConnection())
            {
                var employee = await connection.QuerySingleOrDefaultAsync<Employee>(query, new { id });
                return employee;
            }
        }

        /// <summary>
        /// Returns list of all employees
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var query = "Select * from Employees";
            using(var connection = _dapperContext.CreateConnection())
            {
                var employees = await connection.QueryAsync<Employee>(query);
                return employees.ToList();
            }
        }
    }
}
