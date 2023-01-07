using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke() 
        {
            var values = sm.TGetList();
            return View(values);
        }
    }
}
