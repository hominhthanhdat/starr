import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom } from "rxjs";

import { BaseURLService } from "./baseurl.service";

@Injectable()
export class ContractAPIService{


    constructor(
        private baseURLService: BaseURLService,
        private httpClient: HttpClient
    ){}

    
}