import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { BindingComponent } from './AngularCoreConcepts/binding/binding.component';
import { HomeComponent } from './home/home.component';
import { DirectivesComponent } from './AngularCoreConcepts/directives/directives.component';
import { PipesComponent } from './AngularCoreConcepts/pipes/pipes.component';
import { RoutingComponent } from './AngularCoreConcepts/routing/routing.component';
import { FormsComponent } from './AngularCoreConcepts/forms/forms.component';
import { LifeCycleHooksComponent } from './AngularCoreConcepts/life-cycle-hooks/life-cycle-hooks.component';
import { ComponentcommunicationComponent } from './AngularCoreConcepts/componentcommunication/componentcommunication.component';
import { SignalsComponent } from './AngularCoreConcepts/signals/signals.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'binding', component: BindingComponent },
  { path: 'directives', component: DirectivesComponent },
  { path: 'pipes', component: PipesComponent },
  { path: 'routing', component: RoutingComponent },
  { path: 'forms', component: FormsComponent },
  { path: 'lifecycle-hooks', component: LifeCycleHooksComponent },
  { path: 'componentcommunication', component: ComponentcommunicationComponent },
  { path: 'parent-child', component: ComponentcommunicationComponent },
  { path: 'signals', component: SignalsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
