import {Component, Input, Output, EventEmitter, HostListener} from '@angular/core';
import { Task } from '../../models/tasks/task.model';
import {DatePipe, NgForOf, NgIf} from '@angular/common';
import {DeploymentTask} from '../../models/tasks/deployment-task.model';
import {ImplementationTask} from '../../models/tasks/implementation-task.model';
import {MaintenanceTask} from '../../models/tasks/maintenance-task.model';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  imports: [
    NgForOf,
    NgIf,
    DatePipe
  ],
  styleUrls: ['./task-list.component.scss']
})
export class TaskListComponent {
  @Input() tasks: Task[] = [];
  @Input() unassignedTasks: Task[] = [];
  @Input() selectedUserId: number | null = null;
  @Output() assignTasks = new EventEmitter<{ taskIds: number[], userId: number }>();

  selectedTaskIds: number[] = [];

  onTaskChecked(taskId: number, event: Event): void {
    const checked = (event.target as HTMLInputElement).checked;
    if (checked) {
      this.selectedTaskIds.push(taskId);
    } else {
      this.selectedTaskIds = this.selectedTaskIds.filter(id => id !== taskId);
    }
  }

  assignSelectedTasks(): void {
    if (this.selectedUserId !== null) {
      this.assignTasks.emit({ taskIds: this.selectedTaskIds, userId: this.selectedUserId });
    }
  }

  @HostListener('window:beforeunload', ['$event'])
  onBeforeUnload(event: BeforeUnloadEvent) {
    if (this.selectedTaskIds.length > 0) {
      event.preventDefault();
    }
  }

  isMaintenanceTask(task: Task): task is MaintenanceTask {
    return (task as MaintenanceTask).dueDate !== undefined;
  }

  isImplementationTask(task: Task): task is ImplementationTask {
    return (task as ImplementationTask).taskContent !== undefined;
  }

  isDeploymentTask(task: Task): task is DeploymentTask {
    return (task as DeploymentTask).scope !== undefined;
  }
}
