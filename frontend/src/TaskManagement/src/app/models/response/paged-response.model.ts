export interface PagedResponse<T> {
  errors: string[],
  data: T[],
  pageNumber: number,
  pageSize: number,
  totalCount: number,
  totalPages: number,
  hasNextPage: boolean,
  hasPreviousPage: boolean
}
