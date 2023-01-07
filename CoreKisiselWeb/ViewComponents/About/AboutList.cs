using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.About
{
    public class AboutList :ViewComponent
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke() 
        {
            var values=am.TGetList();
            return View(values);
        }
    }
}
