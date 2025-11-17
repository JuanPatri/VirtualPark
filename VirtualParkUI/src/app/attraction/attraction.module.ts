import { NgModule } from '@angular/core';
import { AttractionRoutingModule } from './attraction-routing.module';
import { AttractionPageComponent } from './attraction-page/attraction-page.component';
import { AttractionDeletedComponent } from './attraction-deleted/attraction-deleted.component';

@NgModule({
  imports: [AttractionRoutingModule, AttractionPageComponent],
  declarations: [
  
    AttractionDeletedComponent
  ],
})
export class AttractionModule {}