import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Task } from '../models/tasks/task.model';

@Injectable({ providedIn: 'root' })
export class TaskService {
  private apiUrl = 'https://localhost:44383/api';

  constructor(private http: HttpClient) {}

  getDeploymentTasks(params: any): Observable<Task[]> {
    return this.http.get<Task[]>(`${this.apiUrl}/DeploymentTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  getImplementationTasks(params: any): Observable<Task[]> {
    return this.http.get<Task[]>(`${this.apiUrl}/ImplementationTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  getMaintenanceTasks(params: any): Observable<Task[]> {
    return this.http.get<Task[]>(`${this.apiUrl}/MaintenanceTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc`, { params });
  }

  addTaskToUser(taskIds: number[], userId: number): Observable<any> {
    return this.http.post(`${this.apiUrl}/Tasks/AddTaskToUser`, { tasksIds: taskIds, userId });
  }
}
