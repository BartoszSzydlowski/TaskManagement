import { UserType } from './user-type.model';

export interface User {
  id: number;
  name: string;
  surname: string;
  userType: UserType;
}
