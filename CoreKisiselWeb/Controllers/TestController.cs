using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
