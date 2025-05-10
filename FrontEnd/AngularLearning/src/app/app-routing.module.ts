import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { BindingComponent } from './AngularCoreConcepts/binding/binding.component';
import { HomeComponent } from './home/home.component';
import { DirectivesComponent } from './AngularCoreConcepts/directives/directives.component';
import { PipesComponent } from './AngularCoreConcepts/pipes/pipes.component';
import { RoutingComponent } from './AngularCoreConcepts/routing/routing.component';
import { ComponentCommunicationComponent } from './AngularCoreConcepts/component-communication/component-communication/component-communication.component';
import { FormsComponent } from './AngularCoreConcepts/forms/forms.component';
import { LifeCycleHooksComponent } from './AngularCoreConcepts/life-cycle-hooks/life-cycle-hooks.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'binding', component: BindingComponent },
  { path: 'directives', component: DirectivesComponent },
  { path: 'pipes', component: PipesComponent },
  { path: 'routing', component: RoutingComponent },
  { path: 'component-communication', component: ComponentCommunicationComponent },
  { path: 'forms', component: FormsComponent },
  { path: 'lifecycle-hooks', component: LifeCycleHooksComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
