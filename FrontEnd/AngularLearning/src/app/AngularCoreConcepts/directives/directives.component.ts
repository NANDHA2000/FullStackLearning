import { Component } from '@angular/core';

@Component({
  selector: 'app-directives',
  templateUrl: './directives.component.html',
  styleUrls: ['./directives.component.css']
})
export class DirectivesComponent {
  selectedTab: string = 'ngIf';
  isVisible = true;
  isGreen = true;
  languages = ['Angular', 'React', 'Vue', 'Svelte'];
}
