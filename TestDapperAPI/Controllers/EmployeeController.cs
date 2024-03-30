using Microsoft.AspNetCore.Mvc;
using TestDapperAPI.Models;
using TestDapperAPI.Repositories;

namespace TestDapperAPI.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Get's all employees list
        /// </summary>
        /// <returns></returns>
        [Route("api/employees")]
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetEmployees();
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }            
        }

        [Route("api/employees/employee/{Id:int}")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeeById(int Id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeById(Id);
                if (employee == null)
                {
                    return BadRequest();
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("api/employees/{Id:int}")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeesByCompanyId(int Id)
        {
            try
            {
                var employees = await _employeeRepository.GetEmployeesByCompanyId(Id);
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
