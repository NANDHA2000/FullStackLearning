import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  parentMessage = '👨 Message from Parent Component';
  receivedMessage = '';

  handleChildMessage(event: string) {
    this.receivedMessage = event;
  }
}
