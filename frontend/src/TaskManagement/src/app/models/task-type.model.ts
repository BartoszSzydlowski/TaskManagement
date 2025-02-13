export interface TaskType {
  id: number;
  name: string;
}

export enum TaskTypes {
  Deployment = 1,
  Maintenance = 2,
  Implementation = 3
}
