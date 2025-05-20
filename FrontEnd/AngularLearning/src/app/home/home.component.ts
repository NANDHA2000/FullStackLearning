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
    { name: 'Forms', path: '/forms' },
    { name: 'Life Cycle Hooks', path: '/lifecycle-hooks' },
    { name: 'Component Communication', path: '/componentcommunication' },
    { name: 'Parent Child Communication', path: '/parent-child' },
    { name: 'Signals', path: '/signals' }
  ];
}
