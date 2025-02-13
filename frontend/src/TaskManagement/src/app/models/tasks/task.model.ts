import { User } from '../user.model';

export interface Task {
  id: number;
  name: string;
  difficulty: number;
  status: TaskStatus;
  user: User
}

export enum TaskStatus {
  TODO = 2
}
