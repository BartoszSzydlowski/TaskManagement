import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TaskType } from '../models/task-type.model';
import {ApiResponse} from '../models/response/api-response.model';

@Injectable({ providedIn: 'root' })
export class TaskTypeService {
  private apiUrl = 'https://localhost:44383/api/TaskTypes/GetAll';

  constructor(private http: HttpClient) {}

  getAllTaskTypes(): Observable<ApiResponse<TaskType>> {
    return this.http.get<ApiResponse<TaskType>>(this.apiUrl);
  }
}
