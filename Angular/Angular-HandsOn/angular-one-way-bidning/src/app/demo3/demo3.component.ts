import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {

  title:string='Angular is ClientSide Framework'
  url:string='http://www.google.co.in'
  img_path="../../assets/11.jpg";
  constructor() { }

  ngOnInit(): void {
  }

}
