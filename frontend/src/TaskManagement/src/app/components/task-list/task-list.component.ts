import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Task } from '../../models/tasks/task.model';
import {NgForOf} from '@angular/common';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  imports: [
    NgForOf
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
}
