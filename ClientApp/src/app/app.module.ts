import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';

import { LoginComponent } from './login/login.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeInfoComponent } from './employee-info/employee-info.component';
import { UserHomeComponent } from './user-home/user-home.component';
import { AuthGuard } from './guards/auth.guard';
import { HttpInterceptorService } from './services/http-interceptor.service';
import { ErrorInterceptorService } from './services/error-interceptor.service';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { AdminGuard } from './guards/admin.guard';
import { DesignationwiseSalaryComponent } from './employee-highchart/designationwiseSalary-barchart.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LoginComponent,
    UserHomeComponent,
    AdminHomeComponent,
    EmployeeComponent,
    EmployeeInfoComponent,
    DesignationwiseSalaryComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'login', component: LoginComponent },
    { path: 'employee', component: EmployeeComponent},
    { path: 'user-home', component: UserHomeComponent, canActivate: [AuthGuard] },
    { path: 'admin-home', component: AdminHomeComponent, canActivate: [AdminGuard] },
    { path: 'employee-info/:id', component: EmployeeInfoComponent},
    { path: 'employee-highcharts', component: DesignationwiseSalaryComponent}

], { relativeLinkResolution: 'legacy' })
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: HttpInterceptorService, multi: true },
  { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptorService, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
