using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Listesi";
            var values = sm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {
            ViewBag.v1 = "Yetenek Ekleme";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill) 
        {
            sm.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id) 
        {
            var values=sm.TGetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id) 
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Düzenleme";
            var values = sm.TGetByID(id); //sayfa yüklendiğinde Id bulucaz.
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            sm.TUpdate(skill);
            return RedirectToAction("Index");
        }

    }
}
