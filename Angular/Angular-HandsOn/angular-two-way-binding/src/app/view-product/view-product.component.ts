import { Component, OnInit } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})
export class ViewProductComponent implements OnInit {
products:Product[]=[];
product:Product;
  constructor() {
    this.product=new  Product(); //initializing the product object
   }

  ngOnInit(): void {
  }
  AddProduct():void
  {
    //add product to the products array
    console.log(this.product)
    this.products.push(this.product);
    console.log(this.products);
    this.product=new  Product(); //reset the product object
  }

}
