import { TopClaimTopic } from './../../_models/top-claim-topic';
import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartOptions } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { first } from 'rxjs/operators';
import { TopClaimTopicService } from '../../_services/top-claim-topic.service';

@Component({
  selector: 'app-top-claim-topic',
  templateUrl: './top-claim-topic.component.html',
  styleUrls: ['./top-claim-topic.component.css']
})
export class TopClaimTopicComponent implements OnInit {

  constructor(private topClaimTopicService: TopClaimTopicService) { }


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
          labelString: 'Count'
        },
      }]
    }
  }

  public update(){
    this.topClaimTopicService.get()
    .pipe(first())
    .subscribe(counts => {
      var data=[];
      var label=[];


      counts.forEach(count => {
          label.push(count.topicDescription.toString());
          data.push(count.count);

      });
      this.chartLabels = label;

      this.chartData = data;
    });

  }
}
