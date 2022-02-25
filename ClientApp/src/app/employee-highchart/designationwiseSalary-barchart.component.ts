import { Component, OnInit } from '@angular/core';
import * as HighCharts from 'highcharts';

@Component({
  selector: 'app-home',
  templateUrl: './designationwiseSalary-barchart.component.html',
})
export class DesignationwiseSalaryComponent implements OnInit {
    title = 'HighCharts';
    data:any;
    constructor() { }
  
    ngOnInit() {
      this.barChartPopulation();
     }
  
    barChartPopulation() {
        
      HighCharts.chart('barChart', {
        chart: {
          type: 'bar'
        },
        title: {
          text: 'Yearly salary by designation'
        },
        xAxis: {
          categories: ['l1', 'l2', 'l3', 'l4', 'l5'],
        },
        yAxis: {
          min: 0,
          title: {
            text: 'Population (millions)',
            align: 'high'
          },
        },
        tooltip: {
          valueSuffix: ' millions'
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
          name: 'Year 2016',
          data: [1216, 1001, 4436, 738, 40]
        }]
      });
    }
}