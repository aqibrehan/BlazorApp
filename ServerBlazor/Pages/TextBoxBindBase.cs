using DataModel.Models;
using Microsoft.AspNetCore.Components;
using ServerBlazor.Service;

namespace ServerBlazor.Pages
{
    public class TextBoxBindBase:ComponentBase
    { 

        [Inject]
     public IEmployeeService EmployeeService { get; set; }

    public Employee employee { get; set; } = new Employee();
    [Parameter]
    public string Id { get; set; }
    protected async override Task OnInitializedAsync()
    {
        employee = (await EmployeeService.GetEmployee(int.Parse(Id)));
    }

}
}
