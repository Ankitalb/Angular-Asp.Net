import { Component, OnInit } from '@angular/core';
import { Visit } from 'src/app/Models/visit.model';
import { VisitService } from 'src/app/services/visit/visit.service';

@Component({
  selector: 'app-executive',
  templateUrl: './executive.component.html',
  styleUrls: ['./executive.component.css']
})
export class ExecutiveComponent implements OnInit {
  list:Visit[]
  empList:any[];
  constructor(private service:VisitService) { }

  ngOnInit(): void {
  
    this.service.getAllVisits().subscribe(res=>{
      this.list=res;
    });
   

    this.service.getAllEmployees().subscribe(res=>{
      this.empList=res;
    });
    


  }

}
