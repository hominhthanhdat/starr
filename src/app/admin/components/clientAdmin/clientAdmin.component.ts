import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Table } from 'primeng/table';
import {DropdownModule} from 'primeng/dropdown';
import { SortEvent } from 'primeng/api';
import { Subscription } from 'rxjs';
import { EmployeeAPI } from 'src/app/models/employeeAPI.model';
import { EmployeeAPIService } from 'src/app/services/employeeAPIService.service';
declare const toggle :any;
@Component({

  templateUrl: './clientAdmin.component.html',
  styleUrls: ['../../admin.component.css'],
})
export class ClientAdminComponent implements OnInit {
    
  constructor(private employeeService: EmployeeAPIService) {}

    ngOnInit() {
  
      }
      
    

}
