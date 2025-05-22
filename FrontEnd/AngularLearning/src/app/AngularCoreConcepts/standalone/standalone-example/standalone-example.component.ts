import { Component } from '@angular/core';

@Component({
  selector: 'app-standalone-example',
  standalone: true,
  templateUrl: './standalone-example.component.html',
  styleUrls: ['./standalone-example.component.css']
})
export class StandaloneExampleComponent {
  title = 'Standalone Component';
  message = 'This component is not declared in any module!';
}
