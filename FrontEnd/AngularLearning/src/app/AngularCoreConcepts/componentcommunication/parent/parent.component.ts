import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {

  parentMessage = 'Hello from Parent!';
  childReply = '';

  handleChildReply(reply: string) {
    this.childReply = reply;
  }

}
