using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
