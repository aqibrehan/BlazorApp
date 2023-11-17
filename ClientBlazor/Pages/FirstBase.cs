using DataModel;
using DataModel.Models;
using Microsoft.AspNetCore.Components;

namespace ClientBlazor.Pages
{
    public class FirstBase:ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
           await Task.Run(LoadEmplyee);
          //  return base.OnInitializedAsync();
        }
        private void LoadEmplyee()
        {
            Thread.Sleep(5000);
            Employees = new List<Employee>()
            {
               new Employee{ Id = 1,Name="Muhammad Aqib",City="Karachi"},
               new Employee{ Id = 2,Name="Muhammad Saqib",City="Karachi"}
            };
        }
    }
}
