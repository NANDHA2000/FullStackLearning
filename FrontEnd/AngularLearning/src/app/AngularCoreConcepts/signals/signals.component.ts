import { Component, computed, effect, signal } from '@angular/core';

@Component({
  selector: 'app-signals',
  templateUrl: './signals.component.html',
  styleUrls: ['./signals.component.css']
})
export class SignalsComponent {
// Basic signal
  counter = signal(0);

  // Computed signal
  doubleCounter = computed(() => this.counter() * 2);

  // Array to hold logs for UI display
  logs: string[] = [];

  // Effect updates logs array instead of console
  logEffect = effect(() => {
    const val = this.counter();
    this.logs = [...this.logs, `Counter changed: ${val}`];
  });

  // Tab management
  signalTab: string = 'basic';

  // Methods
  increment() {
    this.counter.set(this.counter() + 1);
  }

  reset() {
    this.counter.set(0);
  }
}
