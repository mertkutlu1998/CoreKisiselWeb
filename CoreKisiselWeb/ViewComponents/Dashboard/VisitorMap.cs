using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
