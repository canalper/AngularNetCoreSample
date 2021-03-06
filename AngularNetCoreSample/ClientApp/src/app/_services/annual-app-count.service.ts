﻿import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AnnualCount } from '../_models/annual-acount';

@Injectable({ providedIn: 'root' })
export class AnnualCountService {
    constructor(private http: HttpClient) { }

    get() {
        return this.http.get<[AnnualCount]>(`${environment.apiUrl}/Dashboard/GetAnnualApplicationCount`);
    }
}
