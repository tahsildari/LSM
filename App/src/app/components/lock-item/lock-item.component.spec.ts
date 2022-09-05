import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LockItemComponent } from './lock-item.component';

describe('LockItemComponent', () => {
  let component: LockItemComponent;
  let fixture: ComponentFixture<LockItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LockItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LockItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
