import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { IncidenceService } from '../../../backend/services/incident/incident.service';
import { CreateIncidenceRequest } from '../../../backend/services/incident/models/CreateIncidenceRequest';
import { ButtonsComponent } from '../../components/buttons/buttons.component';
import { MessageComponent } from '../../components/messages/message.component';
import { MessageService } from '../../components/messages/service/message.service';
import { AuthRoleService } from '../../auth-role/auth-role.service';
import { TypeIncidenceService } from '../../../backend/services/type-incidence/type-incidence.service';
import { TypeIncidenceModel } from '../../../backend/services/type-incidence/models/TypeIncidenceModel';

@Component({
  selector: 'app-incidence-form',
  standalone: true,
  imports: [CommonModule, FormsModule, ButtonsComponent, MessageComponent],
  templateUrl: './incidence-form-page.component.html',
  styleUrls: ['./incidence-form-page.component.css']
})
export class IncidenceFormComponent implements OnInit {
  form: CreateIncidenceRequest = {
    typeId: '',
    description: '',
    start: '',
    end: '',
    attractionId: '',
    active: 'true'
  };
 
  typeList: TypeIncidenceModel[] = [];

  isOperator = false;

  constructor(
    private readonly incidenceService: IncidenceService,
    private readonly messageService: MessageService,
    private readonly authRoleService: AuthRoleService,
    private readonly router: Router,
    private readonly typeService: TypeIncidenceService, 
  ) {}

  ngOnInit() {
    this.isOperator = this.authRoleService.hasAnyRole(['Operator']);
    this.loadTypes();
  }

    loadTypes() {
    this.typeService.getAll().subscribe({
      next: (res) => this.typeList = res,
      error: () => this.messageService.show('Error loading types.', 'error')
    });
  }

  save() {
    if (!this.form.typeId || !this.form.description || !this.form.start || !this.form.end || !this.form.attractionId) {
      this.messageService.show('Please fill in all required fields.', 'error');
      return;
    }

    this.incidenceService.create(this.form).subscribe({
      next: () => {
        this.messageService.show('Incidence created successfully.', 'success');
        this.router.navigate(['/incidences']);
      },
      error: () => this.messageService.show('Error creating incidence.', 'error')
    });
  }

  cancel() {
    this.router.navigate(['/incidences']);
  }
}
