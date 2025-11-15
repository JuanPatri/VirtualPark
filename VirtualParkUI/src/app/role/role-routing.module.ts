import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{ RolePageComponent } from './role-page/role-page.component';
import { RolePermissionPageComponent } from './role-permission-page/role-permission-page.component';

const routes: Routes = [
    { path: '', component: RolePageComponent,
      children: [
        { path: 'permissions', component: RolePermissionPageComponent }
      ]}
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class RoleRoutingModule {}