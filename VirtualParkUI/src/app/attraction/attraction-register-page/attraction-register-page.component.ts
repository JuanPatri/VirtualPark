import { Component, inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ButtonsComponent } from '../../components/buttons/buttons.component';
import { CreateAttractionFormComponent } from '../../business-components/create-attraction-form/create-attraction-form.component';

@Component({
  selector: 'app-attraction-register-page',
  standalone: true,
  imports: [RouterLink, ButtonsComponent, CreateAttractionFormComponent],
  templateUrl: './attraction-register-page.component.html',
  styleUrls: ['./attraction-register-page.component.css']
})
export class AttractionRegisterPageComponent {
  private http = inject(HttpClient);
  private apiUrl = '/api/attractions';

  onSubmit(payload: any) {
    this.http.post(this.apiUrl, payload).subscribe({
      next: () => alert('Attraction creada '),
      error: (e) => alert('Error creando: ' + e.message)
    });
  }
}