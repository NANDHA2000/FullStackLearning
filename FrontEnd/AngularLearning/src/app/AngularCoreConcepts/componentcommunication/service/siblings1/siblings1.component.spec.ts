import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Siblings1Component } from './siblings1.component';

describe('Siblings1Component', () => {
  let component: Siblings1Component;
  let fixture: ComponentFixture<Siblings1Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Siblings1Component]
    });
    fixture = TestBed.createComponent(Siblings1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
