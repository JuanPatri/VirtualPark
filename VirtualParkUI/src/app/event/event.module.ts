import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EventRoutingModule } from './event-routing.module';
import { EventPageComponent } from './event-list-page/event-page.component';
import { ButtonsComponent } from '../components/buttons/buttons.component';
import { EventCreateFormComponent } from './event-create-form/event-create-form.component';

@NgModule({
  declarations: [
    EventCreateFormComponent
  ],
  imports: [
    CommonModule,
    EventRoutingModule,
    ButtonsComponent
  ]
})
export class EventModule {}
