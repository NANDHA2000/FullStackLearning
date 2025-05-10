import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LifeCycleHooksComponent } from './life-cycle-hooks.component';

describe('LifeCycleHooksComponent', () => {
  let component: LifeCycleHooksComponent;
  let fixture: ComponentFixture<LifeCycleHooksComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LifeCycleHooksComponent]
    });
    fixture = TestBed.createComponent(LifeCycleHooksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
