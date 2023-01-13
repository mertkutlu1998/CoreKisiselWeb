using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Portfolio
{
    public class SlideList:ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke() 
        {
            var values=pm.TGetList();
            return View(values);
        }
    }
}
