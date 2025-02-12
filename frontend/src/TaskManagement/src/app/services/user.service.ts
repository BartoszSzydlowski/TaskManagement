import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user.model';
import {ApiResponse} from '../models/response/response.model';

@Injectable({ providedIn: 'root' })
export class UserService {
  private apiUrl = 'https://localhost:44383/api/Users/GetAll';

  constructor(private http: HttpClient) {}

  getAllUsers(): Observable<ApiResponse<User>> {
    return this.http.get<ApiResponse<User>>(this.apiUrl);
  }
}
