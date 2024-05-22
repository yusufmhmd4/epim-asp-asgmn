import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {TodoContainerComponent} from "../todo-container/todo-container.component"

@Component({
  selector: 'app-todo-list',
  standalone:true,
  imports:[CommonModule,TodoContainerComponent],
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.css'
})
export class TodoListComponent {


  darkTheme:boolean=false;

  addTodoModal:boolean=false;


  onThemeChange():void{
    this.darkTheme=!this.darkTheme
  }
  

onModalChange():void{
  this.addTodoModal=!this.addTodoModal
}
  

}
