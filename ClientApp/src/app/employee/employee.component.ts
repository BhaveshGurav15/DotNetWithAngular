import { Component } from '@angular/core';
import { Employee } from '../models/employee';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './employee.component.html',
})
export class EmployeeComponent {
  constructor(private employeeService:EmployeeService){}
  employeeList:any//Employee[];

  ngOnInit():void {
    this.getEmployeeList();
   }
 
   getEmployeeList() {
     this.employeeService.getEmployeeData().subscribe((res) => {
       this.employeeList = res;
       if (res)
         console.log("ok");
         console.log(res);
     },
       err =>
         console.log("faild")
     );
   }

}
