using DataModel.Models;
using Microsoft.AspNetCore.Components;
using ServerBlazor.Service;

namespace ServerBlazor.Pages
{
    public class EmployeeBase:ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public IEnumerable<Employee> EmployeesList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmployeesList = (await employeeService.GetEmployees()).ToList();
        }




    }
}
