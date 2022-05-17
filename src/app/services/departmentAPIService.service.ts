import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom } from "rxjs";
import { DepartmentAPI } from "../models/departmentAPI.model";
import { BaseURLService } from "./baseurl.service";

@Injectable()
export class DeparmentAPIService{


    constructor(
        private baseURLService: BaseURLService,
        private httpClient: HttpClient
    ){}
        // 1.get all
        // 2.create
        // 3.update
        // 4.change status
    
        public async GetAll(){
            var value = this.httpClient.get(this.baseURLService.BaseURL+'department/getall');
            return await lastValueFrom(value);
        }
        public async AddNewDepartment(department:DepartmentAPI){
            var value = this.httpClient.post(this.baseURLService.BaseURL+'department/create',department);
            return await lastValueFrom(value);
        }
    
        public async UpdateDepartment(department:DepartmentAPI){
            var value = this.httpClient.put(this.baseURLService.BaseURL+'department/update',department);
            return await lastValueFrom(value);
        }
    
        
        public async ChangeDepartmentStatus(id:number){
            var value = this.httpClient.get(this.baseURLService.BaseURL+'department/changestatus/'+id)
            return await lastValueFrom(value)
        }


}