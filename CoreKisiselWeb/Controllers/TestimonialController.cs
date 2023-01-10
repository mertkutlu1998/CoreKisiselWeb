using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = tm.TGetList();
            return View(values);
        }
    }
}
