import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AttractionRegisterPageComponent } from './attraction-register-page/attraction-register-page.component';
import { AttractionEditPageComponent } from './attraction-edit-page/attraction-edit-page.component';

const routes: Routes = [
  { path: 'register', component: AttractionRegisterPageComponent },
  { path: ':id/edit', component: AttractionEditPageComponent },
  { path: '', redirectTo: 'register', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AttractionRoutingModule { }