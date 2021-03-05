using Moq;
using NUnit.Framework;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.UnitTests.Controllers
{
    [TestFixture]
    public class ToDoesControllerTests
    {
        private Mock<IToDoesService> _toDoesService;
        private ToDoesController _controller;

        [SetUp]
        public void SetUp()
        {
            _toDoesService = new Mock<IToDoesService>();
            _controller = new ToDoesController
            {
                _service = _toDoesService.Object
            };
        }
        [Test]
        public void DeleteConfirmed_WhenCalled_DeleteTheObject()
        {
            
            _controller._service.DeleteFromTheList(1);
            _toDoesService.Verify(x=>x.DeleteFromTheList(1));
        }
        [Test]
        public void Create_WhenCalled_AddTheNewThingToTheList()
        {
            var toDo = new ToDo();
            _controller._service.AddToTheList("1", toDo);
            _toDoesService.Verify(x => x.AddToTheList("1", toDo));
        }
        [Test]
        public void DoneConfirmed_WhenCalled_ChangePropertyIsDoneAsTrue()
        {
             _controller._service.DoneTheThingFromList(1);
             _toDoesService.Verify(x => x.DoneTheThingFromList(1));
        }
        [Test]
        public void Edit_WhenCalled_EditTheThingFromList()
        {
            var toDo = new ToDo();
            _controller._service.EditTheThingOfTheList(toDo);
            _toDoesService.Verify(x => x.EditTheThingOfTheList(toDo));
        }
    }
}
