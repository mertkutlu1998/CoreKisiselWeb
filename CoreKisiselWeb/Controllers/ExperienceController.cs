using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Listesi";
            var values = em.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience() 
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience) 
        {
            em.TAdd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id) 
        {
            var values = em.TGetByID(id);
            em.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
