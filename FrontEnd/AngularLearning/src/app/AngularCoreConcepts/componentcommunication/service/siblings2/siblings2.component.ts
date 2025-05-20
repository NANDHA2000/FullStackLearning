import { Component } from '@angular/core';
import { SiblingService } from '../sibling.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-siblings2',
  templateUrl: './siblings2.component.html',
  styleUrls: ['./siblings2.component.css']
})
export class Siblings2Component {
  
receivedMessage: string = '';

receivedData = '';
subscription!: Subscription;

  constructor(private siblingService: SiblingService) {}

  ngOnInit(): void {
    this.siblingService.currentMessage.subscribe(message => {
      this.receivedMessage = message;
    });

    this.subscription = this.siblingService.customEvent$.subscribe(data => {
      this.receivedData = data;
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}
