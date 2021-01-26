import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { VisitService } from 'src/app/services/visit/visit.service';
import {Visit } from '../../Models/visit.model'
@Component({
  selector: 'app-visit-new',
  templateUrl: './visit-new.component.html',
  styleUrls: ['./visit-new.component.css']
})
export class VisitNewComponent implements OnInit {

  constructor(private router:Router,private service:VisitService) { }
   v:Visit;
  ngOnInit(): void {

     this.v=new Visit();
  }


  onSubmit()
  {
        this.service.addVisit(this.v).subscribe(res=>{
        alert("visit added ")
        this.router.navigate(['/visits']); 
      });
  }
}
