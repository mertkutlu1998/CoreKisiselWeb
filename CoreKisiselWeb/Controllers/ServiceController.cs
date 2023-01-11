using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace CoreKisiselWeb.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        ServiceValidator sv = new ServiceValidator();
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Listesi";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmet Listesi";
            var values = sm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Hizmet Ekleme";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ValidationResult result = sv.Validate(service);
            if (result.IsValid) //eğer geçerliyse
            {
                sm.TAdd(service);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
