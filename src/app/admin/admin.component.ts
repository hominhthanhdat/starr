import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Subscription } from 'rxjs';
declare const toggle :any;
@Component({
  selector: 'app-root',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class AdminComponent implements OnInit {
    status: boolean=false;
    data: any;
    chartOptions: any;
    subscription: Subscription;
    namePage:string;
  
   ngOnInit(): void {
     this.namePage="Admin";
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
    this.status = !this.status
   }
   changeNamePage(e:string){
    this.namePage = e;
   }
}
