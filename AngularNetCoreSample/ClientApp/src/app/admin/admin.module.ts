import { NgModule} from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { routing } from './admin.routing';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgxGalleryModule } from '@kolkov/ngx-gallery';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';


import { AdminComponent } from './admin/admin.component';
import { RouterModule } from '@angular/router';
import { LayoutModule } from '../layout/layout.module';
import { AnnualApplicationCountComponent } from './annual-application-count/annual-application-count.component';
import { AplicationStatusComponent } from './aplication-status/aplication-status.component';
import { CallTurningIntoApplicationComponent } from './call-turning-into-application/call-turning-into-application.component';
import { TopClaimTopicComponent } from './top-claim-topic/top-claim-topic.component';

@NgModule({
	imports: [
		CommonModule,
		routing,
		LayoutModule,
		NgbModule,
		RouterModule,
		NgxGalleryModule,
    FormsModule,
    ChartsModule
	],
	declarations: [
        AdminComponent,
        IndexComponent,
    AnnualApplicationCountComponent,
    AplicationStatusComponent,
    CallTurningIntoApplicationComponent,
    TopClaimTopicComponent
	]
})
export class AdminModule { }
