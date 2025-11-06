import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RankingRoutingModule } from './ranking-routing.module';
import { RankingListPageComponent } from './ranking-list-page/ranking-list-page.component';


@NgModule({
  declarations: [
    RankingListPageComponent
  ],
  imports: [
    CommonModule,
    RankingRoutingModule
  ],
})
export class RankingModule { }
