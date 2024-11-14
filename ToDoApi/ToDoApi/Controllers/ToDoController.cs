using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;
using ToDoApi.Services;

namespace ToDoApi.Controllers {
    [ApiController]
    [Route("api/todos")]
    public class ToDoController : ControllerBase {
        private readonly IToDoService _ToDoService;

        public ToDoController(IToDoService toDoService) {
            _ToDoService = toDoService;
        }

        [HttpGet]
        public ActionResult<List<ToDoItem>> GetItems() => _ToDoService.GetItems();

        [HttpGet("{itemID}")]
        public ActionResult<ToDoItem> GetItem(int itemID) => _ToDoService.GetItem(itemID);

        [HttpPost]
        public ActionResult<ToDoItem> AddItem(ToDoItem item) => _ToDoService.AddItem(item);

        [HttpPut("{itemID}")]
        public IActionResult UpdateItem(int itemID, ToDoItem item) {
            if (itemID != item.ItemID) return BadRequest();
            ToDoItem updatedItem = _ToDoService.UpdateItem(item);
            return UpdateItem == null ? NotFound() : NoContent();
        }

        [HttpDelete("{itemID}")]
        public IActionResult DeleteItem(int itemID) {
            bool deleted = _ToDoService.DeleteItem(itemID);
            return deleted ? NoContent() : NotFound();
        }
    }
}
