import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {ApiResponse} from '../models/response/api-response.model';
import {DeploymentTask} from '../models/tasks/deployment-task.model';
import {ImplementationTask} from '../models/tasks/implementation-task.model';
import {MaintenanceTask} from '../models/tasks/maintenance-task.model';
import {BaseService} from './base.service';

@Injectable({ providedIn: 'root' })
export class TaskService extends BaseService {

  getDeploymentTasks(params: any): Observable<ApiResponse<DeploymentTask>> {
    return this.get<DeploymentTask>('DeploymentTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  getImplementationTasks(params: any): Observable<ApiResponse<ImplementationTask>> {
    return this.get<ImplementationTask>('ImplementationTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  getMaintenanceTasks(params: any): Observable<ApiResponse<MaintenanceTask>> {
    return this.get<MaintenanceTask>('MaintenanceTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  addTaskToUser(taskIds: number[], userId: number): Observable<any> {
    return this.post<any>(`Tasks/AddTaskToUser`, { tasksIds: taskIds, userId });
  }
}

export interface AddTaskToUser {
  tasksIds: number[];
  userId: number;
}
