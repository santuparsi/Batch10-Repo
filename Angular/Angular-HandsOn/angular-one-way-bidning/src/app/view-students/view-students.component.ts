import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
@Component({
  selector: 'app-view-students',
  templateUrl: './view-students.component.html',
  styleUrls: ['./view-students.component.css']
})
export class ViewStudentsComponent implements OnInit {
//student array
students:Student[]
  constructor() {
    //initialize the student array
    this.students=[
      {studentId:1,studentName:'Kamal',studentAge:10},
      {studentId:2,studentName:'Ram',studentAge:11},
      {studentId:3,studentName:'Raghu',studentAge:10},
      {studentId:4,studentName:'Shital',studentAge:11},
    ]
  }

  ngOnInit(): void {
  }

}
