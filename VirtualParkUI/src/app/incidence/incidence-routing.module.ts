import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IncidencePageListComponent } from './incidence-list-page/incidence-list-page.component';

const routes: Routes = [
    { path: '', component: IncidencePageListComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IncidenceRoutingModule { }
