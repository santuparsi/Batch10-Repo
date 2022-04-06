import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductService } from './Services/product.service';
import { OrderService } from './Services/order.service';
import { ViewallComponent } from './viewall/viewall.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewallComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,

  ],
  providers: [ProductService,OrderService],
  bootstrap: [AppComponent]
})
export class AppModule { }
