import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VisitRegistrationApiRepository } from '../../repositories/visitRegistration-api-repository';
import { VisitScoreRequest } from './models/VisitScoreRequest';
import { AttractionModel } from '../attraction/models/AttractionModel';

@Injectable({
    providedIn: 'root'
})
export class VisitRegistrationService {
    constructor(private readonly repository: VisitRegistrationApiRepository) {}

    recordScoreEvent(token: string, payload: VisitScoreRequest): Observable<void> {
        return this.repository.recordScoreEvent(token, payload);
    }

    upToAttraction(visitId: string, attractionId: string): Observable<void> {
        return this.repository.upToAttraction(visitId, attractionId);
    }

    downToAttraction(visitId: string): Observable<void> {
        return this.repository.downToAttraction(visitId);
    }

    getAvailableAttractions(visitorId: string): Observable<AttractionModel[]> {
        return this.repository.getAvailableAttractions(visitorId);
    }
}
