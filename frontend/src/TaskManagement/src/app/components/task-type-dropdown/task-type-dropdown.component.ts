import { Component, Output, EventEmitter, OnInit } from '@angular/core';
import { TaskTypeService } from '../../services/task-type.service';
import {TaskType, TaskTypes} from '../../models/task-type.model';
import {NgForOf} from '@angular/common';

@Component({
  selector: 'app-task-type-dropdown',
  templateUrl: './task-type-dropdown.component.html',
  imports: [
    NgForOf
  ],
  styleUrls: ['./task-type-dropdown.component.scss']
})
export class TaskTypeDropdownComponent implements OnInit {
  taskTypes: TaskType[] = [];
  @Output() taskTypeSelected = new EventEmitter<TaskTypes>();

  constructor(private taskTypeService: TaskTypeService) {}

  ngOnInit(): void {
    this.taskTypeService.getAllTaskTypes().subscribe((types) => {
      this.taskTypes = types.data;
    });
  }

  onSelect(event: Event): void {
    const selectedValue = (event.target as HTMLSelectElement).value;
    const selectedType = (TaskTypes as any)[selectedValue];
    this.taskTypeSelected.emit(selectedType);
  }
}
