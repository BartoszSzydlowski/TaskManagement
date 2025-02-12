import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TaskType } from '../models/task-type.model';

@Injectable({ providedIn: 'root' })
export class TaskTypeService {
  private apiUrl = 'https://localhost:44383/api/TasksTypes/GetAll';

  constructor(private http: HttpClient) {}

  getAllTaskTypes(): Observable<TaskType[]> {
    return this.http.get<TaskType[]>(this.apiUrl);
  }
}
