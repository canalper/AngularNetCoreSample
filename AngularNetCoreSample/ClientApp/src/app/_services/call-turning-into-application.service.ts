﻿import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { CallTurningIntoApplication } from '../_models/call-turning-into-application';

@Injectable({ providedIn: 'root' })
export class CallTurningIntoApplicationService {
    constructor(private http: HttpClient) { }

    get() {
        return this.http.get<[CallTurningIntoApplication]>(`${environment.apiUrl}/Dashboard/GetCallTurningIntoApplication`);
    }
}
