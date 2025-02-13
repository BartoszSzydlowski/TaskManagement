import {Component} from '@angular/core';
import {TaskService} from './services/task.service';
import {Task, TaskStatus} from './models/tasks/task.model';
import {UserDropdownComponent} from './components/user-dropdown/user-dropdown.component';
import {NgForOf, NgIf} from '@angular/common';
import {TaskTypeDropdownComponent} from './components/task-type-dropdown/task-type-dropdown.component';
import {TaskListComponent} from './components/task-list/task-list.component';

@Component({
  selector: 'app-root',
  imports: [
    UserDropdownComponent,
    TaskTypeDropdownComponent,
    TaskListComponent,
    NgForOf,
    NgIf
  ],
  templateUrl: './app.component.html'
})
export class AppComponent {
  tasks: Task[] = [];
  unassignedTasks: Task[] = [];
  errors: string[] = [];
  selectedUserId: number = 0;
  title: string = "TaskManagement";
  taskType: TaskTypes | null = null;
  successMessage: string | null = null;

  constructor(private taskService: TaskService) {}

  getTasks(taskType: TaskTypes, userId: number){
    this.errors = [];
    this.successMessage = null;
    this.selectedUserId = userId;
    this.taskType = taskType;
    const paramsAssigned = { pageNumber: 1, pageSize: 10, userId: userId };
    const paramsUnassigned = { pageNumber: 1, status: TaskStatus.TODO, pageSize: 10, userId: 0 };
    if (taskType === TaskTypes.Deployment) {
      this.taskService.getDeploymentTasks(paramsAssigned).subscribe(tasks => this.tasks = tasks.data);
      this.taskService.getDeploymentTasks(paramsUnassigned).subscribe(tasks => this.unassignedTasks = tasks.data);
    } else if (taskType === TaskTypes.Implementation) {
      this.taskService.getImplementationTasks(paramsAssigned).subscribe(tasks => this.tasks = tasks.data);
      this.taskService.getImplementationTasks(paramsUnassigned).subscribe(tasks => this.unassignedTasks = tasks.data);
    } else if (taskType === TaskTypes.Maintenance) {
      this.taskService.getMaintenanceTasks(paramsAssigned).subscribe(tasks => this.tasks = tasks.data);
      this.taskService.getMaintenanceTasks(paramsUnassigned).subscribe(tasks => this.unassignedTasks = tasks.data);
    }
  }

  onTaskTypeSelected(taskType: TaskTypes) {
    this.taskType = taskType;
    this.getTasks(taskType, this.selectedUserId);
  }

  onUserSelected(userId: number) {
    this.selectedUserId = userId;
    if (this.taskType != null) {
      this.getTasks(this.taskType, userId);
    }
  }

  assignTasksToUser({ taskIds, userId }: { taskIds: number[], userId: number }) {
    this.taskService.addTaskToUser(taskIds, userId).subscribe({
      next: () => {
        this.errors = [];
        if (this.taskType) {
          this.getTasks(this.taskType, this.selectedUserId);
          taskIds.length = 0;
          userId = 0;
        }
        this.successMessage = "Tasks assigned successfully";
      },
      error: err => {
        this.successMessage = null;
        this.errors = err.error.Errors;
      }
    });
  }
}

export enum TaskTypes {
  Deployment = 1,
  Maintenance = 2,
  Implementation = 3
}
