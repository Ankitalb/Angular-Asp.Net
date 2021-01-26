import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-visits',
  templateUrl: './visits.component.html',
  styleUrls: ['./visits.component.css']
})
export class VisitsComponent implements OnInit {

  constructor(private router:Router) { }
  user:any;
  ngOnInit(): void {
    this.user=localStorage.getItem('uname');
  }
  logout()
  {
    localStorage.clear();
    this.router.navigate(['/login']);
  }
}
