using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infrastructure.IRepository;
using DataModel.Models;

using ServerBlazor.Pages;
using WebApi.Infrastructure.Repository;
using Microsoft.VisualBasic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                IEnumerable<Employee> Employee;
                Employee = await _employeeRepository.GetEmployees();
                return Ok(Employee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }
        [HttpGet("id:int")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
           

            var  employee = await _employeeRepository.GetEmployees(id);
                if(employee == null)
                {
                    return NotFound();
                }

                

                return employee;



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }


        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
              
                if (employee == null)
                {
                    return BadRequest();
                }

          var createdEmploye= await _employeeRepository.AddEmployees(employee);

              



                return CreatedAtAction(nameof(GetEmployees), new {id= createdEmploye.Id}, createdEmploye);



            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult<Employee>> UpdateEmployee(int id,Employee employee)
        {
            try
            {
             
                if (id != employee.Id)
                {
                    return BadRequest("Id MisMatch");
                }
                var employeUpdate = await _employeeRepository.GetEmployees(id);
                if(employeUpdate == null) 
                {
                    return NotFound($"Employee Id={id} not Found ");
                }



                return  await _employeeRepository.UpdateEmployees(employee);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }


        [HttpDelete("{id:int}")]

        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {

              
                var employeDelete = await _employeeRepository.GetEmployees(id);
                if (employeDelete == null)
                {
                    return NotFound($"Employee Id={id} not Found ");
                }



                return await _employeeRepository.DeleteEmployees(id);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Search(string name)
        {
            try
            {
               

               var  result = await _employeeRepository.Search(name);
                if (result.Any())
                {
                    return Ok(result);
                }


                return NotFound();
              


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }
        }

    }
}
