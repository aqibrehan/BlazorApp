using DataModel.Models;
using ServerBlazor.Pages;


namespace ServerBlazor.Service
{
    public class EmplyeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmplyeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetFromJsonAsync<Employee>($"https://localhost:7128/api/Employee/id:int?id={id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
          

            return await _httpClient.GetFromJsonAsync<Employee[]>("https://localhost:7128/api/Employee");

          
        }
    }
}
