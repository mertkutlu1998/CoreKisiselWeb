using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace CoreKisiselWeb.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager cm = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke() 
        {
            return View();  
        }
    }
}
