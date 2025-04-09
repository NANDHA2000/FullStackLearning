import { Component } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-sibling1',
  templateUrl: './sibling1.component.html',
  styleUrls: ['./sibling1.component.css']
})
export class Sibling1Component {
  message = '';

  constructor(private dataService: DataService) {}

  sendMessage() {
    this.dataService.setMessage(this.message);
  }
}
