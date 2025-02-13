import { Task } from './task.model';

export interface DeploymentTask extends Task {
  scope: string;
}
