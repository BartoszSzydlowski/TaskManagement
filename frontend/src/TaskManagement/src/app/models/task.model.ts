export interface Task {
  id: number;
  title: string;
  status: 'Done' | 'ToDo';
  difficulty: number;
  userId?: number;
}
