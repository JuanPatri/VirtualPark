import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { SessionService } from '../../../backend/services/session/session.service';
import { LoginRequest } from '../../../backend/services/session/models/LoginRequest';
import { UserLoginFormComponent } from '../../business-components/user/user-login-form/user-login-form.component';
import { ButtonsComponent } from '../../components/buttons/buttons.component';
import { MessageService } from '../../../backend/services/message/message.service';
import { MessageComponent } from '../../components/messages/message.component';

@Component({
    selector: 'app-user-login-page',
    standalone: true,
    imports: [CommonModule, UserLoginFormComponent, ButtonsComponent, MessageComponent],
    templateUrl: './user-login-page.component.html',
    styleUrls: ['./user-login-page.component.css'],
})
export class UserLoginPageComponent {
    @ViewChild(UserLoginFormComponent) loginForm!: UserLoginFormComponent;

    isLoading = false;
    errorMessage = '';

    constructor(
        private readonly sessionService: SessionService,
        private readonly router: Router,
        private readonly _messageService: MessageService
    ) {}

    onSubmit(credentials: LoginRequest) {
        this.isLoading = true;

        this.sessionService.login(credentials).subscribe({
            next: (res) => {
                const token = res.token;

                this.sessionService.getSession(token).subscribe({
                    next: () => {
                        this.isLoading = false;
                        this._messageService.show('Login successful!', 'success');
                        this.router.navigate(['/user/home']);
                    },

                    error: (err) => {
                        this.isLoading = false;

                        const backendMsg =
                            err?.error?.message ??
                            err?.error?.Message ??
                            err?.message ??
                            'Failed to get session.';

                        this._messageService.show(backendMsg, 'error');
                    }
                });
            },

            error: (err) => {
                this.isLoading = false;

                const backendMsg =
                    err?.error?.message ??
                    err?.error?.Message ??
                    err?.message ??
                    'Invalid email or password.';

                this._messageService.show(backendMsg, 'error');
            }
        });
    }


    handleLogin() {
        if (this.loginForm) {
            this.loginForm.emitForm();
        }
    }

    handleRegister() {
        this.router.navigate(['/user/register']);
    }
}