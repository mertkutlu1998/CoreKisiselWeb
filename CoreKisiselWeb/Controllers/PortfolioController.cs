using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            PortfolioValidator pv=new PortfolioValidator();
            ValidationResult results=pv.Validate(portfolio); //portfolio validate kontrol et ona göre işlem yap.
            if (results.IsValid) //eğer geçerliyse
            {
                pm.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); //hatalar dönecek
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id) 
        {
            var values = pm.TGetByID(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id) 
        {
            ViewBag.v1 = "Proje Düzenleme";
            ViewBag.v2 = "Proje";
            ViewBag.v3 = "Düzenleme";
            var values = pm.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator pv = new PortfolioValidator();
            ValidationResult results= pv.Validate(portfolio);

            if (results.IsValid)  //eğer geçerliyse dogruysa yani
            {
                pm.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
