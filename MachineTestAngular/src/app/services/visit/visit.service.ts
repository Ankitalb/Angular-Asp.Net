import { Injectable } from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


import {Visit} from '../../Models/visit.model'
@Injectable({
  providedIn: 'root'
})
export class VisitService {

  baseUrl=environment.apiUrl;
  constructor(private http:HttpClient) { }




  public getVisit(id:number):Observable<Visit>
  {
    return this.http.get<Visit>(this.baseUrl+'VisitTables/'+id).pipe(
      map(res=>{        
        return res;
      })
    );
  }

  public updateVisit(id:number,visit:Visit)
  {
    return this.http.put(this.baseUrl+'VisitTables/'+id,visit);
  }

  public addVisit(visit:Visit )
  {
    return this.http.post(this.baseUrl+'VisitTables/',visit);
  }

  public deleteVisit(id:number)
  {
    return this.http.delete(this.baseUrl+'VisitTables/'+id);
  }

  public getAllVisits()
  {
   return this.http.get<Visit[]>(this.baseUrl+"VisitTables");
  }


  public getAllEmployees()
  {
   return this.http.get<any[]>(this.baseUrl+'GetEmpList');
  }
}
