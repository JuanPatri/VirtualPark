import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StrategyModel } from './models/StrategyModel'
import { CreateStrategyResponse } from './models/CreateStrategyResponse';
import { GetStrategiesKeyResponse } from './models/GetStrategiesKeyResponse';
import { StrategyApiRepository } from '../../repositories/strategy-api-repository'

@Injectable({
    providedIn: 'root'
})
export class StrategyService {
    constructor(private readonly _strategyRepository: StrategyApiRepository) { }
    
    getAll(): Observable<StrategyModel[]>{
        return this._strategyRepository.getAllActiveStrategies();
    }
    
    getAllKeys() : Observable<GetStrategiesKeyResponse[]>{
        return this._strategyRepository.getAllKeyStrategies();
    }
    
    get(date: string) : Observable<StrategyModel>{
        return this._strategyRepository.getActiveStrategy(date);
    }
    
    create(body: StrategyModel) : Observable<CreateStrategyResponse>{
        return this._strategyRepository.createStrategy(body);
    } 
    
    delete(date: string) : Observable<void>{
        return this._strategyRepository.deleteStrategy(date);
    }
    
    update(date: string, strategy : GetStrategiesKeyResponse): Observable<void>{
        return this._strategyRepository.updateStrategy(date, strategy);
    }
}