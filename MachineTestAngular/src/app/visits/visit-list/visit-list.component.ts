import { Component, OnInit } from '@angular/core';
import { Visit } from 'src/app/Models/visit.model';
import {VisitService} from '../../services/visit/visit.service'
@Component({
  selector: 'app-visit-list',
  templateUrl: './visit-list.component.html',
  styleUrls: ['./visit-list.component.css']
})
export class VisitListComponent implements OnInit {

  constructor(private serivice:VisitService) { }


  list:Visit[];
  ngOnInit(): void {

    //getting all visits list
    this.serivice.getAllVisits().subscribe(res=>{
      this.list=res;
    })
  }

 //sorting
  onSort()
  {
    this.list.reverse();
  }
}
