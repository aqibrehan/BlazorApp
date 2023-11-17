using DataModel.Models;
using Microsoft.AspNetCore.Components;

namespace ServerBlazor.Pages
{
    public class SelectListBase:ComponentBase
    {
        public List<Employee> EmployeeList { get; set; }
        public string SelectedValue { get; set; } = "0";

        protected override Task OnInitializedAsync()
        {
            EmployeeList = new List<Employee>()
            {
                new Employee{ Id = 1,Name="Aqib",City="Karachi"},
                new Employee{ Id = 2,Name="Saqib",City="Karachi"},
                new Employee{ Id = 3,Name="Sajid",City="Lahore"}
            };


            return base.OnInitializedAsync();
        }
    }
}
