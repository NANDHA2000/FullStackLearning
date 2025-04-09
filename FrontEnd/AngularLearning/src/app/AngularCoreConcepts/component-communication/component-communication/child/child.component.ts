import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input() messageFromParent: string = '';

  @Output() messageToParent = new EventEmitter<string>();

  sendMessage() {
    this.messageToParent.emit('👶 Message from Child Component');
  }
}
