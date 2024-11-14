import { Component, OnInit } from '@angular/core';
import { TodoService, ToDoItem } from '../services/todo.service';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {
  todos: ToDoItem[] = [];
  newTodoTitle: string = '';

  constructor(private todoService: TodoService) { }

  ngOnInit(): void {
    this.loadTodos();
  }

  loadTodos(): void {
    this.todoService.getItems().subscribe((todos) => this.todos = todos);
  }

  addTodo(): void {
    if (this.newTodoTitle.trim()) {
      const newTodo: ToDoItem = { itemID: 0, title: this.newTodoTitle, completed: false };
      this.todoService.addItem(newTodo).subscribe((todo) => {
        this.todos.push(todo);
        this.newTodoTitle = '';
      });
    }
  }

  toggleCompletion(todo: ToDoItem): void {
    todo.completed = !todo.completed;
    this.todoService.updateItem(todo).subscribe();
  }

  deleteTodo(id: number): void {
    this.todoService.deleteItem(id).subscribe(() => {
      this.todos = this.todos.filter((todo) => todo.itemID !== id);
    });
  }
}
