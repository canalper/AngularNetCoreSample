﻿import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { TopClaimTopic } from '../_models/top-claim-topic';

@Injectable({ providedIn: 'root' })
export class TopClaimTopicService {
    constructor(private http: HttpClient) { }

    get() {
        return this.http.get<[TopClaimTopic]>(`${environment.apiUrl}/Dashboard/GetTopClaimTopic`);
    }
}
