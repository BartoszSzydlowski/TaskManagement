import { Component, Output, EventEmitter, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { User } from '../../models/user.model';
import {NgForOf} from '@angular/common';

@Component({
  selector: 'app-user-dropdown',
  templateUrl: './user-dropdown.component.html',
  imports: [
    NgForOf
  ],
  styleUrls: ['./user-dropdown.component.scss']
})
export class UserDropdownComponent implements OnInit {
  users: User[] = [];
  @Output() userSelected = new EventEmitter<number>();

  constructor(private userService: UserService) {}

  ngOnInit(): void {
    this.userService.getAllUsers().subscribe((users) => {
      this.users = users.data;
    });
  }

  onSelect(event: Event): void {
    const selectedUserId = +(event.target as HTMLSelectElement).value;
    this.userSelected.emit(selectedUserId);
  }
}
