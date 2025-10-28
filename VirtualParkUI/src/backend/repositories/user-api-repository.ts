import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import GenericApiRepository from './generic-api-repository';
import { CreateUserRequest } from '../services/user/models/CreateUserRequest';
import { CreateUserResponse } from '../services/user/models/CreateUserResponse';
import { }

@Injectable({ providedIn: 'root' })
export class UserApiRepository extends GenericApiRepository {
    constructor(http: HttpClient) {
        super('users', http);
    }
    
    public getAllUsers(): Observable<Users>
}