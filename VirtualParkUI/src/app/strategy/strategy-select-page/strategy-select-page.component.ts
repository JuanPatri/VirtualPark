import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ButtonsComponent } from '../../components/buttons/buttons.component';
import { StrategyService } from '../../../backend/services/strategy/strategy.service';
import { GetStrategiesKeyResponse } from '../../../backend/services/strategy/models/GetStrategiesKeyResponse';
import { StrategyModel } from '../../../backend/services/strategy/models/StrategyModel';
import { ClockService } from '../../../backend/services/clock/clock.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-strategy-select-page',
  standalone: true,
  imports: [CommonModule, FormsModule, ButtonsComponent],
  templateUrl: './strategy-select-page.component.html',
  styleUrls: ['./strategy-select-page.component.css']
})
export class StrategySelectPageComponent implements OnInit {
    strategies: GetStrategiesKeyResponse[] = [];
    selectedKey: string | null = null;
    isActivating: boolean = false;

    constructor(
        private _strategyService: StrategyService, 
        private _clockService: ClockService
    ) {}

    ngOnInit(): void {
        this._strategyService.getAllKeys().subscribe({
            next: (data) => {
                this.strategies = data;
            },
            error: (err) => {
                console.error('Error loading strategies:', err);
            }
        });
    }

    active(): void {
        if (!this.selectedKey) {
            alert('First, you will select a strategy.');
            return;
        }

        this.isActivating = true;

        this._clockService.get().pipe(
            switchMap(clock => {
                const formattedDate = this.formatDate(clock.dateSystem);
                
                const strategyModel: StrategyModel = {
                    strategyKey: this.selectedKey!,
                    date: formattedDate
                };
                
                console.log('Sending strategy model:', strategyModel);
                
                return this._strategyService.create(strategyModel);
            })
        ).subscribe({
            next: (response) => {
                alert(`Strategy ${this.selectedKey} activated successfully.`);
                console.log('Response:', response);
                this.isActivating = false;
            },
            error: (err) => {
                console.error('Error activating strategy:', err);
                alert(`Error: Could not activate strategy. ${err.message || 'Please try again.'}`);
                this.isActivating = false;
            },
            complete: () => {
                console.log('Strategy activation completed');
            }
        });
    }

    private formatDate(dateString: string): string {
        if (/^\d{4}-\d{2}-\d{2}$/.test(dateString)) {
            return dateString;
        }
        
        const date = new Date(dateString);
        const year = date.getFullYear();
        const month = String(date.getMonth() + 1).padStart(2, '0');
        const day = String(date.getDate()).padStart(2, '0');
        
        return `${year}-${month}-${day}`;
    }
}