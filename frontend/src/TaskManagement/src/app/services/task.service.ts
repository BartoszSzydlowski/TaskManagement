import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {DeploymentTask} from '../models/tasks/deployment-task.model';
import {ImplementationTask} from '../models/tasks/implementation-task.model';
import {MaintenanceTask} from '../models/tasks/maintenance-task.model';
import {BaseService} from './base.service';

@Injectable({ providedIn: 'root' })
export class TaskService extends BaseService {

  getDeploymentTasks(params: any) {
    return this.get<DeploymentTask>('DeploymentTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  getImplementationTasks(params: any) {
    return this.get<ImplementationTask>('ImplementationTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  getMaintenanceTasks(params: any) {
    return this.get<MaintenanceTask>('MaintenanceTasks/GetFilteredByTaskTypeAndSortedByDifficultyDesc', params);
  }

  addTaskToUser(taskIds: number[], userId: number): Observable<any> {
    return this.post<any>(`Tasks/AddTaskToUser`, { tasksIds: taskIds, userId });
  }
}

export interface AddTaskToUser {
  taskIds: number[];
  userId: number;
}
