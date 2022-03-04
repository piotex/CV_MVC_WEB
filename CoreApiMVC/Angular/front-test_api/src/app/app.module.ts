import {HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InspectionComponent } from './inspection/inspection.component';
import { ShowInspectionComponent } from './inspection/show-inspection/show-inspection.component';
import { AdEditInspectionComponent } from './inspection/ad-edit-inspection/ad-edit-inspection.component';
 
import { InspectionApiService } from './inspection-api.service';

@NgModule({
  declarations: [
    AppComponent,
    InspectionComponent,
    ShowInspectionComponent,
    AdEditInspectionComponent
  ],
  imports: [
    BrowserModule,
    //AppRoutingModule,

    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [InspectionApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
