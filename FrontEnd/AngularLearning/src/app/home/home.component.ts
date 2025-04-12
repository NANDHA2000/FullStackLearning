import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  topics = [
    { name: 'Bindings', path: '/binding' },
    { name: 'Directives', path: '/directives' },
    { name: 'Pipes', path: '/pipes' },
    { name: 'Routing', path: '/routing' },
    { name: 'Component Communication', path: '/component-communication' },
    { name: 'Forms', path: '/forms' }
  ];
}
