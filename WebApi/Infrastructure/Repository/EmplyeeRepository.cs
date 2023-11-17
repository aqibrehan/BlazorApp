using DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.DataContext;
using WebApi.Infrastructure.IRepository;

namespace WebApi.Infrastructure.Repository
{
    public class EmplyeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _Context;

        public EmplyeeRepository(ApplicationDbContext context) : base(context)
        {
            _Context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _Context.Employees.ToListAsync();
        }


        public async Task<Employee> AddEmployees(Employee employee)
        {
            var result = await _Context.Employees.AddAsync(employee);
            await _Context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployees(int id)
        {
            var result = await _Context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (result != null)
            {
                _Context.Employees.Remove(result);
                await _Context.SaveChangesAsync();
                return result;
            }
            return null;


        }


        public async Task<Employee> GetEmployees(int id)
        {
            return await _Context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<Employee> UpdateEmployees(Employee employee)
        {
            var result = await _Context.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);

            if (result != null)
            {
                result.Name = employee.Name;
                result.City = employee.City;
                await _Context.SaveChangesAsync();
                return result;
            }
            return null;
        }

     
        public async Task<IEnumerable<Employee>> Search(string name)
        {
            IQueryable<Employee> query = _Context.Employees;
            if(!string.IsNullOrEmpty(name))
            {
                query= query.Where(a => a.Name.Contains(name));
              
            }
            return await query.ToListAsync();
        }


    }
}
