using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";
            var values=pm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio() 
        {
            ViewBag.v1 = "Proje Ekleme";
            ViewBag.v2 = "Proje";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio) 
        {
            pm.TAdd(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id) 
        {
            var values = pm.TGetByID(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
