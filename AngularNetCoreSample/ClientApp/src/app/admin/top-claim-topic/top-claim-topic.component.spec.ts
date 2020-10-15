import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopClaimTopicComponent } from './top-claim-topic.component';

describe('TopClaimTopicComponent', () => {
  let component: TopClaimTopicComponent;
  let fixture: ComponentFixture<TopClaimTopicComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopClaimTopicComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopClaimTopicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
