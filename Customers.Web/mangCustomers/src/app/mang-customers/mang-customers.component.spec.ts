import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MangCustomersComponent } from './mang-customers.component';

describe('MangCustomersComponent', () => {
  let component: MangCustomersComponent;
  let fixture: ComponentFixture<MangCustomersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MangCustomersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MangCustomersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
