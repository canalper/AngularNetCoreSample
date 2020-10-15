import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallTurningIntoApplicationComponent } from './call-turning-into-application.component';

describe('CallTurningIntoApplicationComponent', () => {
  let component: CallTurningIntoApplicationComponent;
  let fixture: ComponentFixture<CallTurningIntoApplicationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallTurningIntoApplicationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallTurningIntoApplicationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
