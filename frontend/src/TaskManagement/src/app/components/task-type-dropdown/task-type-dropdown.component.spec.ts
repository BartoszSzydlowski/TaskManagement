import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskTypeDropdownComponent } from './task-type-dropdown.component';

describe('TaskTypeDropdownComponent', () => {
  let component: TaskTypeDropdownComponent;
  let fixture: ComponentFixture<TaskTypeDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TaskTypeDropdownComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TaskTypeDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
