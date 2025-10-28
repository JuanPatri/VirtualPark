import { Observable } from 'rxjs';
import {Injectable} from "@angular/core";
import { UserModel } from './models/UserModel';
import { CreateUserRequest } from './models/CreateUserRequest';
import { CreateUserResponse } from './models/CreateUserResponse';
import { UserApiRepository } from '../../repositories/user-api-repository';

@Injectable({
    providedIn: 'root'})
export class UserService{
    
}