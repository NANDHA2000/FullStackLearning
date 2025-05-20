import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input() messageFromParent: string = '';
  @Output() replyToParent = new EventEmitter<string>();

  childReply: string = '';

  sendReply() {
    this.replyToParent.emit(this.childReply);
    this.childReply = ''; // Clear input after sending
  }
}
