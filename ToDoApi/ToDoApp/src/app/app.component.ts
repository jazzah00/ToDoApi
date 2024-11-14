import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { TodoService, ToDoItem } from './services/todo.service';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [FormsModule, CommonModule, HttpClientModule],
  providers: [TodoService]
})
export class AppComponent implements OnInit {
  title = 'ToDoApp';
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

  toggleCompletion(todo: ToDoItem) {
    todo.completed = !todo.completed;
    this.todoService.updateItem(todo).subscribe();
  }

  deleteTodo(id: number): void {
    this.todoService.deleteItem(id).subscribe(() => {
      this.todos = this.todos.filter((todo) => todo.itemID !== id);
    });
  }
}
