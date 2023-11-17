using DataModel.Models;
using Microsoft.AspNetCore.Components;

namespace ServerBlazor.Pages
{
    public class EmployeeComponentBase:ComponentBase
    {
        [Parameter]
        public Employee employee { get; set; }
    }
}
