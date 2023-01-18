using CoreKisiselWeb.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreKisiselWeb.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManeger; //depency ınjection kullanıcaz çünkü crud işlemi yapacağız

        public RegisterController(UserManager<WriterUser> userManeger)
        {
            _userManeger = userManeger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {

            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                SurName = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl
            };
            if (p.Password==p.ConfirmPassword)
            {
                var results = await _userManeger.CreateAsync(w, p.Password); //asekronik metod

                if (results.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
