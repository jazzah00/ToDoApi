namespace ToDoApi.Models {
    public class ToDoItem {
        public int ItemID { get; set; } = 0;
        public string Title { get; set; } = "";
        public bool Completed { get; set; } = false;
    }
}
