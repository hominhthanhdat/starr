import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Subscription } from 'rxjs';
declare const toggle :any;
@Component({

  templateUrl: './homeAdmin.component.html',
  styleUrls: ['../../admin.component.css'],
})
export class HomeAdminComponent implements OnInit {
    status: boolean=false;
    data: any;
    chartOptions: any;
    subscription: Subscription;
   ngOnInit(): void {
     this.status = false;
     this.data = {
      labels: ['A','B','C','D'],
      datasets: [
          {
              data: [300, 50, 100,50],
              backgroundColor: [
                  "#FF6384",
                  "#36A2EB",
                  "#FFCE56",
                  "#55F6FF"
              ],
              hoverBackgroundColor: [
                  "#FF6384",
                  "#36A2EB",
                  "#FFCE56",
                  "#55F6FF"
              ]
          }
      ]
  };
   }
   toggleEvent(){
    this.status = !this.status;
   }
}
