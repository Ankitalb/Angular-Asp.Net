import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Visit } from 'src/app/Models/visit.model';
import { VisitService } from 'src/app/services/visit/visit.service';

@Component({
  selector: 'app-visit-details',
  templateUrl: './visit-details.component.html',
  styleUrls: ['./visit-details.component.css']
})
export class VisitDetailsComponent implements OnInit {

  constructor(private service:VisitService,private route:ActivatedRoute,private router:Router) { }
  id:any;
  v:Visit;
  loading=true;;
  ngOnInit(): void {
    //getting url parameter
    this.route.params.subscribe((params:Params)=>{
      this.id=+params['id'];
    });
    this.loading=true;
    this.service.getVisit(this.id).subscribe(res=>{
     this.v=res;
     this.loading=false;
    });
   
  }


    onSubmit()
    {
        this.service.updateVisit(this.id,this.v).subscribe(res=>{
          alert("Information updated successfully");
          this.router.navigate(['/visits']);         
        });  
      
    this.service.getVisit(this.id).subscribe(res=>{
     this.v=res;
    });

    }
}
