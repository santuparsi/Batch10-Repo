import { Component, OnInit } from '@angular/core';
import { GreetService } from '../greet.service';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
name:string;
msg:string;
flowers:string[];
  constructor(private greetService:GreetService) {
    //call service method
    this.flowers=this.greetService.GetFlowers();
   }

  ngOnInit(): void {
  }
  Greet()
  {
    //calling service method
    this.msg=this.greetService.Greet(this.name);
  }

}
