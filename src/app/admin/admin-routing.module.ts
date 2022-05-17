import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from '../app.component';
import { AdminComponent } from './admin.component';
import { ClientAdminComponent } from './components/clientAdmin/clientAdmin.component';

import { EmployeeAdminComponent } from './components/employeeAdmin/employeeAdmin.component';
import { HomeAdminComponent } from './components/homeAdmin/homeAdmin.component';
import { OfferAdminComponent } from './components/offerAdmin/offerAdmin.component';
import { ServiceAdminComponent } from './components/serviceAdmin/servicerAdmin.component';
import { VacancyAdminComponent } from './components/vacancyAdmin/vacancyAdmin.component';

const routes: Routes = [
  {
    path:'admin',component:AdminComponent, children:[
      {path:'',component:HomeAdminComponent},
      {path:'offer',component:OfferAdminComponent},
      {path:'client',component:ClientAdminComponent},
      {path:'employee',component:EmployeeAdminComponent},
      {path:'service',component:ServiceAdminComponent},
      {path:'vacancy',component:VacancyAdminComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
