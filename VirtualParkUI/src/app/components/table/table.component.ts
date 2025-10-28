import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

export interface TableColumn<T = any> {
  key: keyof T | string;
  label: string;
  width?: string;
  align?: 'left' | 'center' | 'right';
}

@Component({
  selector: 'app-generic-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './generic-table.component.html',
  styleUrls: ['./generic-table.component.css']
})
export class TableComponent<T = any> {
  @Input({ required: true }) columns: TableColumn<T>[] = [];
  @Input({ required: true }) data: T[] = [];
  @Input() emptyMessage = 'No data.';
}
