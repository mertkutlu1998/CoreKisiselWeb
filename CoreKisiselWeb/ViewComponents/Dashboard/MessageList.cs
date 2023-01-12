using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class MessageList :ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke() 
        {
            var values=mm.TGetList();
            return View(values);
        }
    }
}
