import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Table } from 'primeng/table';
import {DropdownModule} from 'primeng/dropdown';
import { SortEvent } from 'primeng/api';
import { Subscription } from 'rxjs';

import { EmployeeAPI } from 'src/app/models/employeeAPI.model';
import { EmployeeAPIService } from 'src/app/services/employeeAPIService.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router,ActivatedRoute } from '@angular/router';
import { AccountAPI } from 'src/app/models/accountAPI.model';
import { AccountAPIService } from 'src/app/services/accountAPIService.service';
declare const toggle :any;
@Component({

  templateUrl: './employeeAdmin.component.html',
  styleUrls: ['./employee.component.css'],
})
export class EmployeeAdminComponent implements OnInit {
    
  constructor(
      private employeeService: EmployeeAPIService,
      private formBuilder:FormBuilder,
      private router: Router,
      private activatedRoute: ActivatedRoute,
        private accountService:AccountAPIService
    ) {}

    statusAccount: boolean =false;
    accountForm:FormGroup;
    addForm: FormGroup;
    updateForm:FormGroup;
    customers: EmployeeAPI[];
    representatives: any[];
    statuses: any[];
    uploadedFiles: any[] = [];
    loading: boolean = true;
    show:boolean =false;
    statusAdd: boolean=false;
    activityValues: number[] = [0, 100];
    statusDetail: boolean = false;
    statusUpdate: boolean = false;
    detailEmployee: EmployeeAPI=null;
    ngOnInit() {
        this.employeeService.GetAll().then(customers => {
            this.customers = customers as EmployeeAPI[];
            this.loading = false;
            console.log(customers);
            console.log(typeof customers[1])
        });
        this.accountForm = this.formBuilder.group({
            employeeId:100,
            userName: "",
            password: "", 
            roleAccount: 1,
            email: "", 
            statusAccount: true,
        })
        this.addForm = this.formBuilder.group({
            fullName: "",
            businessId: "",
            phoneNumber: "",
            achievement: "",
            addressEmployee: "",
            photoEmployee: "aa",
            departmentId: "",
            qualityEducation: "",
            statusEmployee: 2,
            grade: "",
            roleEmployee: "",
        })

        
        this.statuses = [
            {label: 'Working', value: '1'},
            {label: 'Available', value: '2'},
            {label: 'Unavailable', value: '3'},
        ]
    }
    showDetails(){
        this.statusDetail = !this.statusDetail
        this.show = !this.show;
    }
    fillData(id:number){
        this.employeeService.GetEmployeeById(id).then(res=>{
                this.detailEmployee = res as EmployeeAPI;
                console.log(this.detailEmployee);
        }).then(res=>this.showDetails());        
    }
    showUpdate(id:number){
       
        this.employeeService.GetEmployeeById(id).then(result => {
            var emp = result as EmployeeAPI
            this.updateForm = this.formBuilder.group({
            employeeId: emp.employeeId,
            fullName: emp.fullName,
            businessId: emp.businessId,
            phoneNumber: emp.phoneNumber,
            achievement: emp.achievement,
            addressEmployee: emp.addressEmployee,
            photoEmployee: emp.photoEmployee,
            departmentId: emp.departmentId,
            qualityEducation: emp.qualityEducation,
            statusEmployee: emp.statusEmployee,
            grade: emp.grade,
            roleEmployee: emp.roleEmployee,
            })  
  },
  error => console.log(error)
  ).then(res=>{ this.statusUpdate = !this.statusUpdate
    this.statusDetail = !this.statusDetail})
    }
    showUpdate1(){
        this.statusUpdate = !this.statusUpdate
        this.show = !this.show;
    }
    showForm(){
        this.statusAdd = !this.statusAdd;
        this.show = !this.show;
      }
    onUpload(event) {
        for(let file of event.files) {
            this.uploadedFiles.push(file);
        }}
   
  customSort(event: SortEvent) {
    event.data.sort((data1, data2) => {
        let value1 = data1[event.field];
        let value2 = data2[event.field];
        let result = null;

        if (value1 == null && value2 != null)
            result = -1;
        else if (value1 != null && value2 == null)
            result = 1;
        else if (value1 == null && value2 == null)
            result = 0;
        else if (typeof value1 === 'string' && typeof value2 === 'string')
            result = value1.localeCompare(value2);
        else
            result = (value1 < value2) ? -1 : (value1 > value2) ? 1 : 0;

        return (event.order * result);
    });
}
  clear(table: Table) {
      table.clear();
  }
  addEmployee(){
    var emp: EmployeeAPI = this.addForm.value
    console.log(emp);
        this.employeeService.AddNewEmployee(emp).then(
            res=>console.log(res),err=>console.log(err)).then(res=>{
                this.showForm()
                window.location.reload()
            })
  }
  updateEmployee(){
   
    var emp: EmployeeAPI = this.updateForm.value;
    console.log(emp);
    this.employeeService.UpdateEmployee(emp).then(res=>{
        this.
        showUpdate1()
    },err=>console.log(err))
  }

  addAccount(){
        var acc:AccountAPI = this.accountForm.value
        this.accountService.AddNewAccount(acc).then(res=>{},err=>console.log(err))
        this.statusAccount = !this.statusAccount
  }
  updateAccount(){

  }
}
