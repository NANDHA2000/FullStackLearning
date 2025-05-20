import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SiblingService {

  // Share Data
  private messageSource = new BehaviorSubject<string>('Initial message from service');
  currentMessage = this.messageSource.asObservable();

  updateMessage(newMessage: string) {
    this.messageSource.next(newMessage);
  }

  // Event Trigger

  private customEvent = new Subject<string>();
  customEvent$ = this.customEvent.asObservable();

  triggerCustomEvent(data: string) {
    this.customEvent.next(data);
  }
}
