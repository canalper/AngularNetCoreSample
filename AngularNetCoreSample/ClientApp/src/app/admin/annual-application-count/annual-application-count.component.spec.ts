import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AnnualApplicationCountComponent } from './annual-application-count.component';

describe('AnnualApplicationCountComponent', () => {
  let component: AnnualApplicationCountComponent;
  let fixture: ComponentFixture<AnnualApplicationCountComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AnnualApplicationCountComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AnnualApplicationCountComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
