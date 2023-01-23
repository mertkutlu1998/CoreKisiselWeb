using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Areas.Writer.Controllers
{
    [Area("Writer")] //writer isimli area ile çalışması için kullanılır.
    public class DefaultController : Controller
    {
        AnnouncementManager am = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = am.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id) 
        {
            var values = am.TGetByID(id);
            return View(values);
        }
    }
}
