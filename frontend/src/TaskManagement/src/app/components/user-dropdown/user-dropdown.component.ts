import {Component, EventEmitter, inject, OnInit, Output} from '@angular/core';
import {UserService} from '../../services/user.service';
import {User} from '../../models/user.model';
import {NgForOf} from '@angular/common';
import {takeUntil} from 'rxjs';
import {UnsubscribeHandler} from '../../handlers/unsubscribe/unsubscribe.handler';

@Component({
  selector: 'app-user-dropdown',
  templateUrl: './user-dropdown.component.html',
  imports: [
    NgForOf
  ],
  styleUrls: ['./user-dropdown.component.scss']
})
export class UserDropdownComponent extends UnsubscribeHandler implements OnInit {
  users: User[] = [];
  @Output() userSelected = new EventEmitter<number>();

  private userService = inject(UserService);

  ngOnInit(): void {
    this.userService.getAllUsers()
      .pipe(takeUntil(this.destroy$))
      .subscribe((users) => {
        this.users = users.data;
    });
  }

  onSelect(event: Event): void {
    const selectedUserId =+ (event.target as HTMLSelectElement).value;
    this.userSelected.emit(selectedUserId);
  }
}
