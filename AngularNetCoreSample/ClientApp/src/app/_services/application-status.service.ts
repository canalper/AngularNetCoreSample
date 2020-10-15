import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { ApplicationStatus } from '../_models/application-status';

@Injectable({ providedIn: 'root' })
export class ApplicationStatusService {
    constructor(private http: HttpClient) { }

    get() {
        return this.http.get<[ApplicationStatus]>(`${environment.apiUrl}/Dashboard/GetApplicationStatusService`);
    }
}
