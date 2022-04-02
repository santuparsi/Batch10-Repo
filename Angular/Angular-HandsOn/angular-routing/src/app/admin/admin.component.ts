import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
name:string;
  constructor(private router:Router) {
    if(localStorage["uname"]!="")
    {
      this.router.navigateByUrl('login')
    }
    else
    {
      this.name=localStorage["uname"]
    }
  }

  ngOnInit(): void {
  }

}
