import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getEmployeeData() {
    return this.http.get('/api/employee/GetEmployeeData');
  }

  getEmployeeDetails(id:string) {
    return this.http.get('/api/employee/GetEmployee/'+id);
  }
  
  getDesignationwiseSalaryData() {
    return this.http.get('/api/employee/GetDesignationwiseSalaryData');
  }
}
