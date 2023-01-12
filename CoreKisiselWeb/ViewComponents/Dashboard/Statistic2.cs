using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class Statistic2 :ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke() 
        {
            ViewBag.v1 = c.Experiences.Count();
            ViewBag.v2 = c.Skills.Count();
            ViewBag.v3 = c.Testimonials.Count();
            return View();
        }
    }
}
