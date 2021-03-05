using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public interface IToDoesService
    {
        void AddToTheList(string currentUserId, ToDo _toDo);
        void EditTheThingOfTheList(ToDo toDo);
        void DeleteFromTheList(int id);
        void DoneTheThingFromList(int id);
        IEnumerable<ToDo> GetMyToDoes(string currentUserId);
    }

    public class ToDoesServiceViewModels : IToDoesService
    {
        private ApplicationDbContext _db;
        public ToDoesServiceViewModels()
        {
            _db = new ApplicationDbContext();
        }

        public void EditTheThingOfTheList(ToDo toDo)
        {
            _db.Entry(toDo).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void AddToTheList(string currentUserId, ToDo _toDo)
        {
            ApplicationUser currentUser = _db.Users.FirstOrDefault(
                u => u.Id == currentUserId);
            _toDo.User = currentUser;
            _db.ToDos.Add(_toDo);
            _db.SaveChanges();
        }

        public void DeleteFromTheList(int id)
        {
            ToDo toDo = _db.ToDos.Find(id);
            _db.ToDos.Remove(toDo);
            _db.SaveChanges();
        }
        public void DoneTheThingFromList(int id)
        {
            ToDo toDo = _db.ToDos.Find(id);
            toDo.IsDone = true;
            _db.SaveChanges();
        }
        public IEnumerable<ToDo> GetMyToDoes(string currentUserId)
        {
            ApplicationUser currentUser = _db.Users.FirstOrDefault
                (u => u.Id == currentUserId);
            return _db.ToDos.ToList().Where(x => x.User == currentUser);
        }
    }
}