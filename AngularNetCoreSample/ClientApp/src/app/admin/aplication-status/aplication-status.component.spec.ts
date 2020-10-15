import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AplicationStatusComponent } from './aplication-status.component';

describe('AplicationStatusComponent', () => {
  let component: AplicationStatusComponent;
  let fixture: ComponentFixture<AplicationStatusComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AplicationStatusComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AplicationStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
