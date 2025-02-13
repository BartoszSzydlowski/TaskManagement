import { Task } from "./task.model";

export interface ImplementationTask extends Task {
  taskContent: string;
}
