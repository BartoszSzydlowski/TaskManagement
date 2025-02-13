import { BaseResponse } from './base-response.model';

export interface PagedResponse<T> extends BaseResponse {
  data: T[],
  pageNumber: number,
  pageSize: number,
  totalCount: number,
  totalPages: number,
  hasNextPage: boolean,
  hasPreviousPage: boolean,
}
