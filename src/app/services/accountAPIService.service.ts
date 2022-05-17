import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom } from "rxjs";
import { AccountAPI } from "../models/accountAPI.model";
import { BaseURLService } from "./baseurl.service";

@Injectable()
export class AccountAPIService{


    constructor(
        private baseURLService: BaseURLService,
        private httpClient: HttpClient
    ){}

    // 1. create 
    // 2. update 
    // 3. getbyId 
    // 4. changeStatus

    public async AddNewAccount(account:AccountAPI){
        var value = this.httpClient.post(this.baseURLService.BaseURL+'account/create',account);
        return await lastValueFrom(value);
    }

    public async UpdateAccount(account:AccountAPI){
        var value = this.httpClient.put(this.baseURLService.BaseURL+'account/update',account);
        return await lastValueFrom(value);
    }

    public async GetAccountById(id:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'account/getbyid/'+id)
        return await lastValueFrom(value)
    }

    public async ChangeAccountStatus(id:number){
        var value = this.httpClient.get(this.baseURLService.BaseURL+'account/changestatus/'+id)
        return await lastValueFrom(value)
    }

    
}