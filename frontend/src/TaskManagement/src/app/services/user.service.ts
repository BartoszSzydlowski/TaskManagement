import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {User} from '../models/user.model';
import {ApiResponse} from '../models/response/api-response.model';
import {BaseService} from './base.service';

@Injectable({ providedIn: 'root' })
export class UserService extends BaseService {

  getAllUsers(): Observable<ApiResponse<User>> {
    return this.get<User>("Users/GetAll");
  }
}
