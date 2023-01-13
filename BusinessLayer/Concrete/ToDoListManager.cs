using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoList;

        public ToDoListManager(IToDoListDal toDoList)
        {
            _toDoList = toDoList;
        }

        public void TAdd(ToDoList t)
        {
            _toDoList.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _toDoList.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _toDoList.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoList.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _toDoList.Update(t);
        }
    }
}
