export interface ApiResponse<T> {
  data: T[];
  errors: string[];
  total: number;
}
