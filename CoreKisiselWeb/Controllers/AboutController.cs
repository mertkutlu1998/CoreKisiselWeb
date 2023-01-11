using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            var values = am.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about) 
        {
            am.TUpdate(about);
            return RedirectToAction("Index","Default");
        }
    }
}
