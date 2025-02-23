import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {TaskType} from '../models/task-type.model';
import {ApiResponse} from '../models/api/response/api-response.model';
import {BaseService} from './base.service';

@Injectable({ providedIn: 'root' })
export class TaskTypeService extends BaseService {

  getAllTaskTypes(): Observable<ApiResponse<TaskType>> {
    return this.get<TaskType>("TaskTypes/GetAll");
  }
}
