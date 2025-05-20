import { Component } from '@angular/core';
import { SiblingService } from '../sibling.service';

@Component({
  selector: 'app-siblings1',
  templateUrl: './siblings1.component.html',
  styleUrls: ['./siblings1.component.css']
})
export class Siblings1Component {
  
message: string = '';
inputData = '';

  constructor(private siblingService: SiblingService) {}

  sendMessage() {
    this.siblingService.updateMessage(this.message);
    this.message = '';
  }

  triggerEvent() {
    this.siblingService.triggerCustomEvent(this.inputData);
    this.inputData = '';
  }
}
