import {HttpClient} from '@angular/common/http';
import {inject} from '@angular/core';
import {Observable} from 'rxjs';
import {ApiResponse} from '../models/api/response/api-response.model';

export class BaseService {

  private apiUrl = 'https://localhost:44383/api';
  private http: HttpClient = inject(HttpClient);

  protected get<T>(url: string, params?: any): Observable<ApiResponse<T>> {
    return this.http.get<ApiResponse<T>>(`${this.apiUrl}/${url}`, { params });
  }

  protected post<TRequest>(url: string, body: TRequest) {
    return this.http.post<any>(`${this.apiUrl}/${url}`, body);
  }
}
