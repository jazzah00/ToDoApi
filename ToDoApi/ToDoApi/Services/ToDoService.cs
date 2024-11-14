using ToDoApi.Models;

namespace ToDoApi.Services {
    public class ToDoService : IToDoService {
        private readonly List<ToDoItem> _Items = [];
        private int _NextID = 1;

        public List<ToDoItem> GetItems() => _Items;

        public ToDoItem GetItem(int itemID) => _Items.FirstOrDefault(i => i.ItemID == itemID);

        public ToDoItem AddItem(ToDoItem item) {
            item.ItemID = _NextID++;
            _Items.Add(item);
            return item;
        }

        public ToDoItem UpdateItem(ToDoItem item) {
            ToDoItem existingItem = GetItem(item.ItemID);
            if (existingItem != null) {
                existingItem.Title = item.Title;
                existingItem.Completed = item.Completed;
            }
            return existingItem;
        }

        public bool DeleteItem(int id) {
            ToDoItem existingItem = GetItem(id);
            return existingItem != null && _Items.Remove(existingItem);
        }
    }
}
