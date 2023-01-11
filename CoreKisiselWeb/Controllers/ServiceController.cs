using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
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
            ValidationResult results = sv.Validate(service);
            if (results.IsValid) //eğer geçerliyse
            {
                sm.TAdd(service);
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
        public IActionResult DeleteService(int id)
        {
            var values = sm.TGetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Hizmet Güncelle";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmet Güncelle";
            var values = sm.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            
            ValidationResult results = sv.Validate(service);

            if (results.IsValid) //eğer geçerliyse(dogruysa)
            {
                sm.TUpdate(service);
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
