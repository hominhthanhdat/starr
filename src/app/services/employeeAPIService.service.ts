import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom } from "rxjs";
import { EmployeeAPI } from "../models/employeeAPI.model";
import { BaseURLService } from "./baseurl.service";

@Injectable()
export class EmployeeAPIService{


    constructor(
        private baseURLService: BaseURLService,
        private httpClient: HttpClient
    ){}
    // 1. create 
    // 2. update 
    // 3. getbyId 
    //3.1 get all
    // 4. changeStatus
    // 5.getbyname 
    // 6.getbyService
    // 7.getbyDeparment
    
    public async GetAll(){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'employee/getall');
        return await lastValueFrom(value);
    }

    public async AddNewEmployee(employee:EmployeeAPI){
        var value = this.httpClient.post(this.baseURLService.BaseURL+'employee/create',employee);
        return await lastValueFrom(value);
    }

    public async UpdateEmployee(employee:EmployeeAPI){
        var value = this.httpClient.put(this.baseURLService.BaseURL+'employee/update',employee);
        return await lastValueFrom(value);
    }

    public async GetEmployeeById(id:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'employee/getbyid/'+id)
        return await lastValueFrom(value)
    }

    public async GetEmployeeByName(name:string){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'employee/getbyname/'+name)
        return await lastValueFrom(value)
    }
    
    public async GetEmployeeByService(id:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'employee/getbyservice/'+id)
        return await lastValueFrom(value)
    }

    public async GetEmployeeByDepartment(id:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'employee/getbydepartment/'+id)
        return await lastValueFrom(value)
    }

    public async ChangeEmployeeStatus(id:number,status:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'account/changestatus/'+id+'/'+status)
        return await lastValueFrom(value)
    }


}