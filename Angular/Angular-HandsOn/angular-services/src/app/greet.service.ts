import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetService {

  constructor() { }
  //service methods
  Add(n1:number,n2:number):number
  {
    let result=n1+n2;
    return result;
  }
  Greet(name:string):string
  {
    return 'Hello '+name;
  }
  GetFlowers():string[]
  {
    return ["Rose","Lilly","Jasmine"]
  }
}
