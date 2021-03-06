import { TopClaimTopic } from './../../_models/top-claim-topic';
import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartOptions } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { first } from 'rxjs/operators';
import { CallTurningIntoApplicationService } from '../../_services/call-turning-into-application.service';

@Component({
  selector: 'app-call-turning-into-application',
  templateUrl: './call-turning-into-application.component.html',
  styleUrls: ['./call-turning-into-application.component.css']
})
export class CallTurningIntoApplicationComponent implements OnInit {

  constructor(private callTurningIntoApplicationService: CallTurningIntoApplicationService) { }

  ngOnInit() {
    this.update();

  }

  public chartLabels:string[] = [];
  public chartData:number[] = [];

  public chartColors = [
    {
      backgroundColor: ['rgba(255,0,0,0.3)', 'rgba(0,255,0,0.3)', 'rgba(0,0,255,0.3)','rgba(255,0,0,0.3)', 'rgba(0,255,0,0.3)', 'rgba(0,0,255,0.3)'],
    },
  ];
  public chartType:string = 'horizontalBar';

  chartOptions = {
 color:[
  'red'
 ],

    tooltips: {
      display: true,
      backgroundColor: '#ffff',
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
        ticks: {
          beginAtZero: true
      },
        display: true,
        scaleLabel: {
          display: true,
          labelString: 'Year',
        }
      }],
      yAxes: [{
        display: true,
        scaleLabel: {
          display: true,
          labelString: 'Percentage'
        },
      }]
    }
  }

  public update(){
    this.callTurningIntoApplicationService.get()
    .pipe(first())
    .subscribe(counts => {
      var data=[];
      var label=[];


      counts.forEach(count => {
          label.push(count.year.toString());
          data.push(count.count);

      });
      this.chartLabels = label;

      this.chartData = data;
    });

  }
}
