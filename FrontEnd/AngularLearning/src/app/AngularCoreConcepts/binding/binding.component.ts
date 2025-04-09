import { Component } from '@angular/core';

@Component({
  selector: 'app-binding',
  templateUrl: './binding.component.html',
  styleUrls: ['./binding.component.css']
})
export class BindingComponent {

  selectedTab: string = 'interpolation';
  showModal: boolean = false;

  bindingSummary = [
    { type: 'Interpolation', syntax: '{{ value }}', direction: 'Component → View', example: '{{ name }}' },
    { type: 'Property', syntax: '[property]="value"', direction: 'Component → View', example: '[src]="imageUrl"' },
    { type: 'Event', syntax: '(event)="handler()"', direction: 'View → Component', example: '(click)="showAlert()"' },
    { type: 'Two-Way', syntax: '[(ngModel)]="value"', direction: 'View ⬌ Component', example: '[(ngModel)]="name"' },
    { type: 'Attribute', syntax: '[attr.attrname]="..."', direction: 'Component → View', example: '[attr.colspan]="2"' },
    { type: 'Class', syntax: '[class.name]="bool"', direction: 'Component → View', example: '[class.active]="isActive"' },
    { type: 'Style', syntax: '[style.prop]="value"', direction: 'Component → View', example: '[style.color]="color"' },
  ];

  name: string = '';
  imageUrl: string = 'https://angular.io/assets/images/logos/angular/angular.png';
  colSpan: number = 2;
  isActive: boolean = true;
  isError: boolean = false;

  showAlert() {
    alert('Button clicked! Event binding works.');
  }
}
