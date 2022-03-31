import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
//initialize the student object
obj:Student=new Student();
  constructor() {
    //Initialize student object data
    this.obj.studentId=3429803;
    this.obj.studentName='Rohan';
    this.obj.studentAge=10;
   }

  ngOnInit(): void {
  }

}
