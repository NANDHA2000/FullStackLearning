import { Component } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-sibling2',
  templateUrl: './sibling2.component.html',
  styleUrls: ['./sibling2.component.css']
})
export class Sibling2Component {
  receivedMessage: string = '';

  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.dataService.message$.subscribe(msg => this.receivedMessage = msg);
  }
}
