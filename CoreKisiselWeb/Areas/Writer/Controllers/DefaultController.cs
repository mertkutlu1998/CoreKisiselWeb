using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Areas.Writer.Controllers
{
    [Area("Writer")] //writer isimli area ile çalışması için kullanılır.
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
