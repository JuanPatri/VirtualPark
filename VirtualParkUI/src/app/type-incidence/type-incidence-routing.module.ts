import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TypeIncidenceListComponent } from './type-incidence-list/type-incidence-list.component';
import { TypeIncidenceFormComponent } from './type-incidence-form-page/type-incidence-form-page.component';

const routes: Routes = [
  { path: '', component: TypeIncidenceListComponent },
  { path: 'new', component: TypeIncidenceFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TypeIncidenceRoutingModule { }
