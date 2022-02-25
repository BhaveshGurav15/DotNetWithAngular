import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../models/employee';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './employee-info.component.html',
})
export class EmployeeInfoComponent {
employeeDetails:any//Employee;
constructor(private route: ActivatedRoute, private employeeService:EmployeeService){}

ngOnInit():void {
  const id = this.route.snapshot.paramMap.get('id');
  this.getEmployeeDetails(id);
 }

 getEmployeeDetails(id:string) {
   this.employeeService.getEmployeeDetails(id).subscribe((res) => {
     this.employeeDetails = res;
     if (res)
       console.log("ok");
       console.log(res);
   },
     err =>
       console.log("faild")
   );
 }
}
