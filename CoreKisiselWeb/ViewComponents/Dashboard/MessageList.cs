using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class MessageList :ViewComponent
    {
        UserMessageManager umm = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke() 
        {
            var values = umm.GetUserMessageWithService();
            return View(values);
        }
    }
}
