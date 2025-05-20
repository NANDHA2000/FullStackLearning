import { Component } from '@angular/core';

@Component({
  selector: 'app-componentcommunication',
  templateUrl: './componentcommunication.component.html',
  styleUrls: ['./componentcommunication.component.css']
})
export class ComponentcommunicationComponent {
selectedView: 'parent-child' | 'sibling' = 'parent-child';
}
