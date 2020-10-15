import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartOptions } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { first } from 'rxjs/operators';
import { AnnualCountService } from '../../_services/annual-app-count.service';

@Component({
  selector: 'app-annual-application-count',
  templateUrl: './annual-application-count.component.html',
  styleUrls: ['./annual-application-count.component.css']
})
export class AnnualApplicationCountComponent implements OnInit {

  constructor(private annualCountService: AnnualCountService) { }




  ngOnInit() {
    this.update();

  }

  public chartLabels:string[] = [];
  public chartData:number[] = [];
  public chartType:string = 'bar';

  chartOptions = {


    tooltips: {
      display: true,
      backgroundColor: '#fff',
      titleFontSize: 14,
      titleFontColor: 'chocolate',
      bodyFontColor: '#000',
      bodyFontSize: 12,
      displayColors: false,
    },

    animation: {
      duration: 1000,
      easing: "easeInOutQuad"
    },
    responsive: true,
    legend: {
      display: false,
      position: 'top',
      cornerRadius: 10,
      titleSpacing: 4,
      footerFontStyle: 'bold',
      multiKeyBackground: '#eee'
    },
    hover: {
      mode: 'nearest',
      intersect: true
    },
    scales: {
      xAxes: [{
        display: true,
        scaleLabel: {
          display: true,
          labelString: 'Year',
        }
      }],
      yAxes: [{
        ticks: {
          beginAtZero: true
      },
        display: true,
        scaleLabel: {
          display: true,
          labelString: 'Count'
        },
      }]
    }
  }

  public update(){
    this.annualCountService.get()
    .pipe(first())
    .subscribe(counts => {
      var data=[];
      var label=[];

      counts.forEach(count => {
          label.push(count.year.toString());
          data.push(count.applyCount);

      });
      this.chartLabels = label;

      this.chartData = data;
    });

  }
}
