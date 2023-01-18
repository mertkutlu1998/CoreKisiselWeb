using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKisiselWeb.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager tdm = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke() 
        {
            var values = tdm.TGetList();
            return View(values);
        }
    }
}
