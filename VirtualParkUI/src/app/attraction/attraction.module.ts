import { NgModule } from '@angular/core';
import { AttractionRoutingModule } from './attraction-routing.module';
import { AttractionPageComponent } from './attraction-page/attraction-page.component';

@NgModule({
  imports: [AttractionRoutingModule],
  declarations: [
    AttractionPageComponent
  ],
})
export class AttractionModule {}