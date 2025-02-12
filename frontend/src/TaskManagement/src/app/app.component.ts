import {Component} from '@angular/core';
import {TaskService} from './services/task.service';
import {Task, TaskStatus} from './models/tasks/task.model';
import {UserDropdownComponent} from './components/user-dropdown/user-dropdown.component';
import {NgForOf} from '@angular/common';
import {TaskTypeDropdownComponent} from './components/task-type-dropdown/task-type-dropdown.component';
import {TaskListComponent} from './components/task-list/task-list.component';

@Component({
  selector: 'app-root',
  imports: [
    UserDropdownComponent,
    TaskTypeDropdownComponent,
    TaskListComponent,
    NgForOf
  ],
  templateUrl: './app.component.html'
})
export class AppComponent {
  tasks: Task[] = [];
  unassignedTasks: Task[] = [];
  errors: string[] = [];
  selectedUserId: number = 0;
  title: string = "TaskManagement";
  taskType: string | null = null;

  constructor(private taskService: TaskService) {}

  getTasks(pageNumber: number, status: TaskStatus, pageSize: number){
    if (this.taskType != null && this.selectedUserId != 0) {
      const params = { pageNumber: 1, status: status, pageSize: 10, userId: this.selectedUserId };
      if (this.taskType === 'Deployment') {
        this.taskService.getDeploymentTasks(params).subscribe(tasks => {
          if (status === TaskStatus.DONE) {
            this.tasks = tasks.data
          }
          else if (status === TaskStatus.TODO) {
            this.unassignedTasks = tasks.data;
          }
        });
      } else if (this.taskType === 'Implementation') {
        this.taskService.getImplementationTasks(params).subscribe(tasks => {
          if (status === TaskStatus.DONE) {
            this.tasks = tasks.data
          }
          else if (status === TaskStatus.TODO) {
            this.unassignedTasks = tasks.data;
          }
        });
      } else if (this.taskType === 'Maintenance') {
        this.taskService.getMaintenanceTasks(params).subscribe(tasks => {
          if (status === TaskStatus.DONE) {
            this.tasks = tasks.data
          }
          else if (status === TaskStatus.TODO) {
            this.unassignedTasks = tasks.data;
          }
        });
      }
    }
    //return { pageNumber: pageNumber, status, pageSize: 10 };
  }

  onTaskTypeSelected(taskType: string) {
    this.taskType = taskType;
    this.getTasks(1, TaskStatus.DONE, 10);
    this.getTasks(1, TaskStatus.TODO, 10);
  }

  onUserSelected(userId: number) {
    this.errors = [];
    this.selectedUserId = userId;
/*    const paramsToDo = { pageNumber: 1, status: 'ToDo', pageSize: 10, userId };
    const paramsDone = { pageNumber: 1, status: 'Done', pageSize: 10, userId };
    this.taskService.getDeploymentTasks(paramsToDo).subscribe(tasks => this.unassignedTasks = tasks.data);
    this.taskService.getDeploymentTasks(paramsDone).subscribe(tasks => this.tasks = tasks.data);*/
    this.getTasks(1, TaskStatus.DONE, 10);
    this.getTasks(1, TaskStatus.TODO, 10);
  }

  assignTasksToUser({ taskIds, userId }: { taskIds: number[], userId: number }) {
    this.taskService.addTaskToUser(taskIds, userId).subscribe({
      next: () => this.errors = [],
      error: err => {
        this.errors = err.error.Errors;
      }
    });
  }
}
