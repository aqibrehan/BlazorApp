using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ServerBlazor.Pages
{
    public class IndexBase:ComponentBase
    {
        public string TextChange { get; set; } = "Click Me";
        public string Changecolor { get; set; } = null;
        public string Cordinates { get; set; } = null;
        public string Name { get; set; } = "Aqib";
        public string colour { get; set; } = "background-color:White";
        protected void changeText()
        {
            if(TextChange== "Click Me")
            {
                TextChange = "Please Click Me";

                Changecolor = "btn btn-primary";
            }
            else
            {
                TextChange = "Click Me";

                Changecolor = "btn btn-success";
            }
        }


        protected void mousemove(MouseEventArgs e)
        {
            Cordinates = $"X cordinate{e.ClientX} and Y cordinate{e.ClientY}";
        }
            
  }
}
