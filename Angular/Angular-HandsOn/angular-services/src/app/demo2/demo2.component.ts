import { Component, OnInit } from '@angular/core';
import { GreetService } from '../greet.service';
@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
n1:number;
n2:number;
result:number;
  constructor(private greetService:GreetService) { }

  ngOnInit(): void {
  }
  Add()
  {
    this.n1=Number(this.n1); //convert string to int
    this.n2=Number(this.n2);

    this.result=this.greetService.Add(this.n1,this.n2);
  }

}
