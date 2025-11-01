import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DropdownMenuComponent } from '../components/dropdown-menu/dropdown-menu.component';
import { HeaderComponent } from '../layouts/header/header.component'



@NgModule({
  declarations: [
      DropdownMenuComponent,
      HeaderComponent
  ],
  imports: [
    CommonModule
  ]
})
export class MainPageModule { }
