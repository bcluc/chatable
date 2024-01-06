using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chatable.Pages
{
    public class HostModel: PageModel
    {
        private readonly AppData appData;
        public HostModel (AppData appData)
        {
            this.appData = appData;
        }
        public void OnGet() 
        {
            var refresh = HttpContext.Request.Cookies["refresh"];
            var access = HttpContext.Request.Cookies["access"];

            appData.refresh = refresh;
            appData.access = access;
        }

        
    }
}
