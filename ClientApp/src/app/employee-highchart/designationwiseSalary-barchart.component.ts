import { Component, OnInit } from '@angular/core';
import * as HighCharts from 'highcharts';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './designationwiseSalary-barchart.component.html',
})
export class DesignationwiseSalaryComponent implements OnInit {
    title = 'Chart';
    data:any;
    xdata:any;
    ydata:any;
    constructor(private employeeService:EmployeeService) { }
  
    ngOnInit() {
      this.barChartPopulation();
     }
  
    barChartPopulation() {
      
      this.employeeService.getDesignationwiseSalaryData().subscribe((res) => {
        this.data = res;
        this.xdata=this.data.map(t=>t.designation_Description).map(String);
        this.ydata=this.data.map(t=>t.salary_Amount).map(Number);
        if (res)
          console.log("ok");
          console.log(res);
          console.log(this.ydata);
      },
        err =>
          console.log("faild")
      );

      HighCharts.chart('barChart', {
        chart: {
          type: 'bar'
        },
        title: {
          text: 'Yearly salary by designation'
        },
        xAxis: {
          //categories: ['l1', 'l2', 'l3', 'l4', 'l5'],
          categories: this.xdata,
        },
        yAxis: {
          min: 0,
          title: {
            text: 'Salary (Rupees)',
            align: 'high'
          },
        },
        tooltip: {
          valueSuffix: ' rupees'
        },
        plotOptions: {
          bar: {
            dataLabels: {
              enabled: true
            }
          }
        },
        series: [{
          type: undefined,
          name: 'Year 2022',
          data: [10000, 20000, 30000]
          //data:this.ydata
        }]
      });
    }
}