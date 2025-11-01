import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { DropdownMenuComponent } from '../../components/dropdown-menu/dropdown-menu.component';

@Component({
    selector: 'app-header',
    standalone: true,
    imports: [CommonModule, RouterModule, DropdownMenuComponent],
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent {
    attractionsMenu = [
        { label: 'List', path: '/attraction' },
        { label: 'Create', path: '/attraction/new' },
        { label: 'Ranking', path: '/ranking' }
    ];

    eventsMenu = [
        { label: 'Event', path: '/events' },
        { label: 'Create', path: '/events/new' }
    ];

    rewardMenu = [
        { label: 'Reward', path: '/reward' },
        { label: 'Create', path: '/rewards/create' },
        
    ]
}