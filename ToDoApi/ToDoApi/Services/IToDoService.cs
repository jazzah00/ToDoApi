using ToDoApi.Models;

namespace ToDoApi.Services {
    public interface IToDoService {
        public List<ToDoItem> GetItems();
        public ToDoItem GetItem(int id);
        public ToDoItem AddItem(ToDoItem item);
        public ToDoItem UpdateItem(ToDoItem item);
        public bool DeleteItem(int id);
    }
}
