using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class OpenProject:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
