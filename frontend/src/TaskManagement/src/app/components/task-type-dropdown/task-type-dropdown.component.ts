import { Component, Output, EventEmitter, OnInit } from '@angular/core';
import { TaskTypeService } from '../../services/task-type.service';
import { TaskType } from '../../models/task-type.model';
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
  @Output() taskTypeSelected = new EventEmitter<string>();

  constructor(private taskTypeService: TaskTypeService) {}

  ngOnInit(): void {
    this.taskTypeService.getAllTaskTypes().subscribe((types) => {
      this.taskTypes = types.data;
    });
  }

  onSelect(event: Event): void {
    const selectedType = (event.target as HTMLSelectElement).value;
    this.taskTypeSelected.emit(selectedType);
  }
}
