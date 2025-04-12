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
import { ParentComponent } from './AngularCoreConcepts/component-communication/component-communication/parent/parent.component';
import { ChildComponent } from './AngularCoreConcepts/component-communication/component-communication/child/child.component';
import { Sibling1Component } from './AngularCoreConcepts/component-communication/component-communication/sibling1/sibling1.component';
import { Sibling2Component } from './AngularCoreConcepts/component-communication/component-communication/sibling2/sibling2.component';
import { ComponentCommunicationComponent } from './AngularCoreConcepts/component-communication/component-communication/component-communication.component';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { FormsComponent } from './AngularCoreConcepts/forms/forms.component';

@NgModule({
  declarations: [
    AppComponent,
    BindingComponent,
    HomeComponent,
    DirectivesComponent,
    PipesComponent,
    CapitalizeWordsPipe,
    RoutingComponent,
    ParentComponent,
    ChildComponent,
    Sibling1Component,
    Sibling2Component,
    ComponentCommunicationComponent,
    FormsComponent
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
