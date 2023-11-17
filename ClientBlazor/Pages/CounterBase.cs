using Microsoft.AspNetCore.Components;

namespace ClientBlazor.Pages
{
    public class CounterBase:ComponentBase
    {
        protected int currentDeCount = 0;
        protected int currentCount = 0;
        protected string Dename = "Muhammad Aqib Rehan";
        protected string name = "Muhammad Aqib ";
        protected void IncrementCount()
        {
            currentCount++;
        }
        protected void DecrementCount()
        {
            currentCount--;
        }
    }

  
}
