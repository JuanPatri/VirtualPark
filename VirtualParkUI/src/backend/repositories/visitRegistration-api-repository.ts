import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import GenericApiRepository from './generic-api-repository';
import { VisitScoreRequest } from '../services/visitRegistration/models/VisitScoreRequest';
import { AttractionModel } from '../services/attraction/models/AttractionModel';

@Injectable({ providedIn: 'root' })
export class VisitRegistrationApiRepository extends GenericApiRepository {
    constructor(http: HttpClient) {
        super('visitRegistrations', http);
    }

    recordScoreEvent(token: string, body: VisitScoreRequest): Observable<void> {
        return this.create<void>(body, true, `scoreEvents/${token}`);
    }

    upToAttraction(visitId: string, attractionId: string): Observable<void> {
        return this.create<void>({}, true, `${visitId}/currentAttraction/${attractionId}`);
    }

    downToAttraction(visitId: string): Observable<void> {
        return this.create<void>({}, true, `${visitId}/currentAttraction`);
    }

    getAvailableAttractions(visitorId: string): Observable<AttractionModel[]> {
        return this.getAll<AttractionModel[]>(`${visitorId}/availableAttractions`);
    }
}
