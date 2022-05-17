import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AdminModule } from './admin/admin.module';
import { AdminPageComponent } from './adminPage.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {ChartModule} from 'primeng/chart';
import {TableModule} from 'primeng/table';
import {ButtonModule} from 'primeng/button';
import {FileUploadModule} from 'primeng/fileupload';
import {DropdownModule} from 'primeng/dropdown';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './Layout/Footer/footer.component';
import { HeaderComponent } from './Layout/Header/header.component';
import { HomeComponent } from './pages/home/home.component';
import { BaseURLService } from './services/baseurl.service';
import { EmployeeAPIService } from './services/employeeAPIService.service';

@NgModule({
  declarations: [
    AppComponent,
    AdminPageComponent,
    FooterComponent,
    HeaderComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AdminModule,
    BrowserAnimationsModule,
    ChartModule,
    TableModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    DropdownModule,
    ButtonModule,
    FileUploadModule,
    IonicModule.forRoot()
    
  ],
  providers: [
    BaseURLService,
    EmployeeAPIService
  ],
  bootstrap: [AdminPageComponent]
})
export class AppModule { }
