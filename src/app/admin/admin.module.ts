import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {DropdownModule} from 'primeng/dropdown';
import { BrowserModule } from '@angular/platform-browser';
import { AdminRoutingModule } from './admin-routing.module';
import { AdminComponent } from './admin.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {ChartModule} from 'primeng/chart';
import {TableModule} from 'primeng/table';
import {ButtonModule} from 'primeng/button';
import {FileUploadModule} from 'primeng/fileupload'
import { IonicModule } from '@ionic/angular';

import { HomeAdminComponent } from './components/homeAdmin/homeAdmin.component';
import { OfferAdminComponent } from './components/offerAdmin/offerAdmin.component';
import { EmployeeAdminComponent } from './components/employeeAdmin/employeeAdmin.component';
import { VacancyAdminComponent } from './components/vacancyAdmin/vacancyAdmin.component';
import { ServiceAdminComponent } from './components/serviceAdmin/servicerAdmin.component';
import { BaseURLService } from '../services/baseurl.service';
import { EmployeeAPIService } from '../services/employeeAPIService.service';
import { ClientAdminComponent } from './components/clientAdmin/clientAdmin.component';
import { AccountAPIService } from '../services/accountAPIService.service';

@NgModule({
  declarations: [
    AdminComponent,
    ClientAdminComponent,
    HomeAdminComponent,
    OfferAdminComponent,
    EmployeeAdminComponent,
    VacancyAdminComponent,
    ServiceAdminComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AdminRoutingModule,
    BrowserAnimationsModule,
    ChartModule,
    TableModule,
    DropdownModule,
    ButtonModule,
    FileUploadModule,
    IonicModule.forRoot()
  ],
  providers: [
    BaseURLService,
    EmployeeAPIService,
    AccountAPIService
  ],
  bootstrap: [AdminComponent]
})
export class AdminModule { }
