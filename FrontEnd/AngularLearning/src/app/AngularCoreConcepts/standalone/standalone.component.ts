import { Component } from '@angular/core';
import { StandaloneExampleComponent } from './standalone-example/standalone-example.component';

@Component({
  selector: 'app-standalone',
  standalone: true,
  imports: [StandaloneExampleComponent],
  templateUrl: './standalone.component.html',
  styleUrls: ['./standalone.component.css']
})
export class StandaloneComponent {

}
