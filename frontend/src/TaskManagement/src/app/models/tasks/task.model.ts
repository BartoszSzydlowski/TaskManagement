import { User } from '../user.model';

export interface Task {
  id: number;
  content: string;
  difficulty: number;
  status: 'Done' | 'ToDo';
  user: User
}
