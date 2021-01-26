import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  baseUrl=environment.apiUrl;

  constructor(private http:HttpClient) { }


  getUser(user:string)
  {
    return this.http.get<any>(this.baseUrl+"Logins/"+user);
  }
}
