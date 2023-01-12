using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar() //sol menü
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavigation() 
        {
            return PartialView();
        }
        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }
    }
}
