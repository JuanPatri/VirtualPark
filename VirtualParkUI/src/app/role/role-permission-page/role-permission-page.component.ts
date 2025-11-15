import { Component } from '@angular/core';
import { AddPermissionRoleFormComponent } from '../../business-components/role/add-permission-role-form/add-permission-role-form.component';
import { RoleService } from '../../../backend/services/role/role.service';
import { RoleModel } from '../../../backend/services/role/models/RoleModel';
import { MessageService } from '../../components/messages/service/message.service';
import { PermissionService } from '../../../backend/services/permission/permission.service';
import { PermissionModel } from '../../../backend/services/permission/models/PermissionModel';

@Component({
    selector: 'app-role-permission-page',
    standalone: true,
    imports: [AddPermissionRoleFormComponent],
    templateUrl: './role-permission-page.component.html',
    styleUrls: ['./role-permission-page.component.css']
})
export class RolePermissionPageComponent {
    errorMessage = '';
    roles: RoleModel[] = [];
    permissions: PermissionModel[] = [];

    constructor(private _roleService: RoleService, private _messageService: MessageService, private _permissionService: PermissionService) {
        this.loadRoles();
        this.loadPermissions();
    }

    loadRoles() {
        this._roleService.getAll().subscribe({
            next: (data: RoleModel[]) => {
                this.roles = data;
            },
            error: (err) => {
                this._messageService.show( `Error fetching roles: ${err.message || 'Please try again.'}`,'error');
            }
        });
    }

    loadPermissions(){
        this._permissionService.getAll().subscribe({
            next: (data: PermissionModel[]) => {
                this.permissions = data;
            },
            error: (err) => {
                this._messageService.show( `Error fetching permissions: ${err.message || 'Please try again.'}`,'error');
            }
    });
}
}