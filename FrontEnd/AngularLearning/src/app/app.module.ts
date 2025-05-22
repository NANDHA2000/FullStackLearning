import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BindingComponent } from './AngularCoreConcepts/binding/binding.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DirectivesComponent } from './AngularCoreConcepts/directives/directives.component';
import { PipesComponent } from './AngularCoreConcepts/pipes/pipes.component';
import { CapitalizeWordsPipe } from './AngularCoreConcepts/pipes/CustomPipes/capitalize-words.pipe';
import { RoutingComponent } from './AngularCoreConcepts/routing/routing.component';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { FormsComponent } from './AngularCoreConcepts/forms/forms.component';
import { LifeCycleHooksComponent } from './AngularCoreConcepts/life-cycle-hooks/life-cycle-hooks.component';
import { ComponentcommunicationComponent } from './AngularCoreConcepts/componentcommunication/componentcommunication.component';
import { Siblings1Component } from './AngularCoreConcepts/componentcommunication/service/siblings1/siblings1.component';
import { Siblings2Component } from './AngularCoreConcepts/componentcommunication/service/siblings2/siblings2.component';
import { ParentComponent } from './AngularCoreConcepts/componentcommunication/parent/parent.component';
import { ChildComponent } from './AngularCoreConcepts/componentcommunication/child/child.component';
import { SignalsComponent } from './AngularCoreConcepts/signals/signals.component';
import { StandaloneComponent } from './AngularCoreConcepts/standalone/standalone.component';



@NgModule({
  declarations: [
    AppComponent,
    BindingComponent,
    HomeComponent,
    DirectivesComponent,
    PipesComponent,
    CapitalizeWordsPipe,
    RoutingComponent,
    FormsComponent,
    LifeCycleHooksComponent,
    ComponentcommunicationComponent,
    Siblings1Component,
    Siblings2Component,
    ParentComponent,
    ChildComponent,
    SignalsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    TableModule,
    ButtonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
