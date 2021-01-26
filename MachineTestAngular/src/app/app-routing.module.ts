import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { from } from 'rxjs';
import { LoginComponent } from './login/login/login.component';
import { SignupComponent } from './signup/signup/signup.component';
import { VisitDetailsComponent } from './visits/visit-details/visit-details.component';
import { VisitListComponent } from './visits/visit-list/visit-list.component';
import { VisitNewComponent } from './visits/visit-new/visit-new.component';
import { VisitsComponent } from './visits/visits.component';
import {AuthGuardGuard} from './visits/auth-guard.guard';
import { ExecutiveComponent } from './executive/executive/executive.component';

const routes: Routes = [

  {
    path:"",
    component:VisitsComponent,
    children:
    [
     {
      path:"visits",
     component:VisitListComponent,
     canActivate:[AuthGuardGuard]
    },
    {
      path:"newvisit",
      component:VisitNewComponent,
      canActivate:[AuthGuardGuard]
      
    } ,
    {
      path:"visits/:id",
      component:VisitDetailsComponent,
      canActivate:[AuthGuardGuard]

    },
    {
      path:'executive',
      component:ExecutiveComponent,
      canActivate:[AuthGuardGuard]
  
    }
  

    ]
  },
  {
    path:"login",
    component:LoginComponent
  }
  ,
  {
    path:"signup",
    component:SignupComponent
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
