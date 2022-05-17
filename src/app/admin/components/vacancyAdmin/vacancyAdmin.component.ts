import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Subscription } from 'rxjs';
declare const toggle :any;
@Component({

  templateUrl: './vacancyAdmin.component.html',
  styleUrls: ['./vacancyAdmin.component.css'],
})
export class VacancyAdminComponent implements OnInit {
    
    status: boolean=false;
   ngOnInit(): void {
       
   }
   showForm(){
     this.status = !this.status;
     console.log(this.status);
   }
}
