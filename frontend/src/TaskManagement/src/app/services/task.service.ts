import {Injectable} from '@angular/core';
import {DeploymentTask} from '../models/tasks/deployment-task.model';
import {ImplementationTask} from '../models/tasks/implementation-task.model';
import {MaintenanceTask} from '../models/tasks/maintenance-task.model';
import {BaseService} from './base.service';
import {AddTaskToUserRequest} from '../models/api/requests/add-task-to-user-request';

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

  addTaskToUser(request: AddTaskToUserRequest) {
    return this.post<AddTaskToUserRequest>(`Tasks/AddTaskToUser`, request);
  }
}
