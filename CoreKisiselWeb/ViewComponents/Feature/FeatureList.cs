using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        //burada tanımlanan metodlar ınvoke ismini alır.
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke() 
        {
            var values=fm.TGetList();
            return View(values);
        }
    }
}
