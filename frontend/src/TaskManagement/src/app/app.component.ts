import { Component } from '@angular/core';
import { TaskService } from './services/task.service';
import { Task } from './models/tasks/task.model';
import {UserDropdownComponent} from './components/user-dropdown/user-dropdown.component';
import {NgIf} from '@angular/common';
import {TaskTypeDropdownComponent} from './components/task-type-dropdown/task-type-dropdown.component';
import {TaskListComponent} from './components/task-list/task-list.component';

@Component({
  selector: 'app-root',
  imports: [
    UserDropdownComponent,
    NgIf,
    TaskTypeDropdownComponent,
    TaskListComponent
  ],
  templateUrl: './app.component.html'
})
export class AppComponent {
  tasks: Task[] = [];
  unassignedTasks: Task[] = [];
  error: string | null = null;

  constructor(private taskService: TaskService) {}

  onTaskTypeSelected(taskType: string) {
    const params = { pageNumber: 1, status: 'Done', pageSize: 10, userId: 1 };
    if (taskType === 'Deployment') {
      this.taskService.getDeploymentTasks(params).subscribe(tasks => this.tasks = tasks);
    } else if (taskType === 'Implementation') {
      this.taskService.getImplementationTasks(params).subscribe(tasks => this.tasks = tasks);
    } else if (taskType === 'Maintenance') {
      this.taskService.getMaintenanceTasks(params).subscribe(tasks => this.tasks = tasks);
    }
  }

  onUserSelected(userId: number) {
    const paramsToDo = { pageNumber: 1, status: 'ToDo', pageSize: 10, userId };
    const paramsDone = { pageNumber: 1, status: 'Done', pageSize: 10, userId };
    this.taskService.getDeploymentTasks(paramsToDo).subscribe(tasks => this.unassignedTasks = tasks);
    this.taskService.getDeploymentTasks(paramsDone).subscribe(tasks => this.tasks = tasks);
  }

  assignTasksToUser({ taskIds, userId }: { taskIds: number[], userId: number }) {
    this.taskService.addTaskToUser(taskIds, userId).subscribe({
      next: () => this.error = null,
      error: err => this.error = err.error.errors
    });
  }
}
