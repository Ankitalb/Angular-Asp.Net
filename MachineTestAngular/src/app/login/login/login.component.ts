import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import {LoginService} from '../../services/login/login-service.service'
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:LoginService,private router:Router) { }

  ngOnInit(): void {
  }

  onSubmit(f:NgForm)
  {
    
    this.service.getUser(f.value.name).subscribe(res=>{
      console.log(res);
       if(res==null)
       {
          alert("No user found");
       }
      else if(res.password!=f.value.password)
      {
        alert("Incorrect Password");
      }
      else{
        localStorage.setItem('role',res.userType);
        localStorage.setItem('uname',res.username);
        if(res.userType=="SC")
        { console.log("hh")
          this.router.navigate(['/visits']);
        }
        else
        this.router.navigate(['/executive'])
      }
    });
  }
}
