import { Component } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})

export class PipesComponent {

  selectedTab = 'date';
  today = new Date();
  message = 'angular pipes are powerful';
  price = 999.99;

}
