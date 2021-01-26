import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login/login.component';
import { SignupComponent } from './signup/signup/signup.component';
import { VisitListComponent } from './visits/visit-list/visit-list.component';
import { VisitDetailsComponent } from './visits/visit-details/visit-details.component';
import { VisitNewComponent } from './visits/visit-new/visit-new.component';
import { FormsModule } from '@angular/forms';
import { VisitsComponent } from './visits/visits.component';
import { ExecutiveComponent } from './executive/executive/executive.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    VisitListComponent,
    VisitDetailsComponent,
    VisitNewComponent,
    VisitsComponent,
    ExecutiveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
