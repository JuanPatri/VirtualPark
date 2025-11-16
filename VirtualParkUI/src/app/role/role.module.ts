import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RoleRoutingModule } from './role-routing.module';
import { RolePageComponent } from './role-page/role-page.component';
import { RoleCreatePageComponent } from './role-create-page/role-create-page.component';
import { RoleListPageComponent } from './role-list-page/role-list-page.component';

@NgModule({
  declarations: [
    RoleListPageComponent
  ],
  imports: [CommonModule, RoleRoutingModule, RolePageComponent, RoleCreatePageComponent]
})
export class RoleModule { }
