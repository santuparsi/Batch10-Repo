import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
user:User
errMsg:string=''
  constructor(private router:Router) {
    this.user=new User();
   }

  ngOnInit(): void {
  }
  Validate()
  {
    let uname=this.user.userName;
    let pwd=this.user.password;
    let role=this.user.role;
    if(uname!="" && pwd!="")
    {
      localStorage["uname"]=uname;
      if(role=="User")
      {
        //redirect to user component
        this.router.navigateByUrl('user'); //naviate to user component
      }
      else if(role=="Admin")
      {
        //redirect to admin component
        this.router.navigateByUrl('admin') //navigate to admin component
      }
    }
    else
    {
      this.errMsg='Pls Enter Username and Password'
    }
  }

}
