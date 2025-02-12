import { Task } from "./task.model";

export interface MaintenanceTask extends Task {
  dueDate: Date,
  serviceList: string,
  serverList: string
}
