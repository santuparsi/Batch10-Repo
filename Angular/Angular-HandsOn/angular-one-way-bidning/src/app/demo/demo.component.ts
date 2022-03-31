import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
//variables
title:string='Angular one-way-binding demo'
studentName:string='Raj';
studentRollNo:number=33332;
studentAge:number=12;
studentWeight:number=34.4;
studentDob:Date=new Date(2010,3,12); //YYYY.MM.DD
isHeStudent:boolean=true;
schoolName:any='DPS';
studentMarks:any=460;
//define the variable without type
a=10;
b='Rahith'

  constructor() { }

  ngOnInit(): void {
  }

}
