import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewallComponent } from './viewall/viewall.component';

const routes: Routes = [
  {path:'view',component:ViewallComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
