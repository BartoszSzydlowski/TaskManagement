import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Task } from '../models/tasks/task.model';
import {ApiResponse} from '../models/response/api-response.model';
import {DeploymentTask} from '../models/tasks/deployment-task.model';
import {ImplementationTask} from '../models/tasks/implementation-task.model';
import {MaintenanceTask} from '../models/tasks/maintenance-task.model';

@Injectable({ providedIn: 'root' })
export class TaskService {
  private apiUrl = 'https://localhost:44383/api';

  constructor(private http: HttpClient) {}

  getDeploymentTasks(params: any): Observable<ApiResponse<DeploymentTask>> {
    return this.http.get<ApiResponse<DeploymentTask>>(`${this.apiUrl}/DeploymentTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  getImplementationTasks(params: any): Observable<ApiResponse<ImplementationTask>> {
    return this.http.get<ApiResponse<ImplementationTask>>(`${this.apiUrl}/ImplementationTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  getMaintenanceTasks(params: any): Observable<ApiResponse<MaintenanceTask>> {
    return this.http.get<ApiResponse<MaintenanceTask>>(`${this.apiUrl}/MaintenanceTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  addTaskToUser(taskIds: number[], userId: number): Observable<any> {
    return this.http.post(`${this.apiUrl}/Tasks/AddTaskToUser`, { tasksIds: taskIds, userId });
  }
}
