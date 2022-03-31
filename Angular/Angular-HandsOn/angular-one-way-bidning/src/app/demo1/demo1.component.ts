import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {

  //arrays
  marks:number[]=[78,89,76,90,88,77];
  cities:string[]=["Chennai","Bangalore","Pune","Mumbai"];
  countries:any=["India","China","Rusia"];
  constructor() { }

  ngOnInit(): void {
  }

}
