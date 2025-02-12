import { UserType } from '../user-type.model';

export interface Task {
  id: number;
  title: string;
  status: 'Done' | 'ToDo';
  difficulty: number;
  userType: UserType
}
