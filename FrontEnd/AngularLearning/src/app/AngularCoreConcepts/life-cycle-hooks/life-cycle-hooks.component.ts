import { Component, DoCheck, OnInit, OnChanges, SimpleChanges, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-life-cycle-hooks',
  templateUrl: './life-cycle-hooks.component.html',
  styleUrls: ['./life-cycle-hooks.component.css']
})
export class LifeCycleHooksComponent implements OnInit, OnChanges, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy {

  logs: string[] = [];
  showComponent: boolean = false;
  simulatedInput: string = 'Initial';

  constructor() {
    this.addLog('🚀 constructor() — Component instance created');
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.addLog('🔁 ngOnChanges() — Simulated input changed: ' + this.simulatedInput);
  }

  ngOnInit(): void {
    this.addLog('✅ ngOnInit() — Component initialized');
  }

  ngDoCheck(): void {
    this.addLog('🔍 ngDoCheck() — Custom change detection');
  }

  ngAfterContentInit(): void {
    this.addLog('📥 ngAfterContentInit() — Content projected');
  }

  ngAfterContentChecked(): void {
    this.addLog('📋 ngAfterContentChecked() — Projected content checked');
  }

  ngAfterViewInit(): void {
    this.addLog('👀 ngAfterViewInit() — View and child views initialized');
  }

  ngAfterViewChecked(): void {
    this.addLog('🔎 ngAfterViewChecked() — View and child views checked');
  }

  ngOnDestroy(): void {
    this.addLog('💥 ngOnDestroy() — Component destroyed');
  }

  toggleComponent(): void {
    this.showComponent = !this.showComponent;
    if (!this.showComponent) {
      this.addLog('💥 Component Removed (Destroyed)');
    } else {
      this.addLog('🟢 Component Created (Triggers Lifecycle Hooks)');
    }
  }

  triggerInputChange(): void {
    this.simulatedInput = 'Updated ' + new Date().toLocaleTimeString();
    this.ngOnChanges({ simulatedInput: { previousValue: '', currentValue: this.simulatedInput, firstChange: false, isFirstChange: () => false } });
  }

  clearLogs(): void {
    this.logs = [];
  }

  addLog(message: string): void {
    const time = new Date().toLocaleTimeString();
    this.logs.push(`[${time}] ${message}`);
  }
}
