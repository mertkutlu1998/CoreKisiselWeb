using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager sam = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke() 
        {
            var values = sam.TGetList();
            return View(values);
        }
    }   
}
