import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { IncidenceRoutingModule } from './incidence-routing.module';
import { Routes } from '@angular/router';
import { IncidencePageListComponent } from './incidence-list-page/incidence-list-page.component';

const routes: Routes = [
  { path: '', component: IncidencePageListComponent },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    IncidenceRoutingModule
  ]
})
export class IncidenceModule { }
