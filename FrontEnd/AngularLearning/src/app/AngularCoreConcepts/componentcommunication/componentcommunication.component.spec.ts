import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentcommunicationComponent } from './componentcommunication.component';

describe('ComponentcommunicationComponent', () => {
  let component: ComponentcommunicationComponent;
  let fixture: ComponentFixture<ComponentcommunicationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ComponentcommunicationComponent]
    });
    fixture = TestBed.createComponent(ComponentcommunicationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
