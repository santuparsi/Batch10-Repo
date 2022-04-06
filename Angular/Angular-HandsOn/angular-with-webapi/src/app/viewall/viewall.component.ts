import { Component, OnInit } from '@angular/core';
import { Product } from '../Models/product';
import { ProductService } from '../Services/product.service';

@Component({
  selector: 'app-viewall',
  templateUrl: './viewall.component.html',
  styleUrls: ['./viewall.component.css']
})
export class ViewallComponent implements OnInit {
products:Product[]
product:Product;
  constructor(private productService:ProductService) {
    this.product=new Product(); //initialize the product model
    //calling service method
    this.productService.GetAllProducts().subscribe(response=>{
        this.products=response; //add GetAllProducts() response data to products array
    })
   // this.GetAllProducts();
   }

  ngOnInit(): void {
  }
  AddProduct()
  {
    this.productService.AddProduct(this.product).subscribe(res=>{
      console.log(res);
      //reset the model
      //this.product=new  Product();
      this.GetAllProducts(); //to refelect new record to the table immediately
    })
  }
  SearchProduct()
  {
    let id=this.product.pid;
    this.productService.GetById(id).subscribe(res=>{
      this.product=res;
    })
  }
  DeleteProduct()
  {
    let id=this.product.pid;
    this.productService.DeleteProduct(id).subscribe(res=>{
      console.log(res);
      this.GetAllProducts();
    })
  }
  EditProduct()
  {
this.productService.EditProduct(this.product).subscribe(res=>{
  console.log(res);
  this.GetAllProducts();
})
  }
  GetAllProducts()
  {
    this.productService.GetAllProducts().subscribe(response=>{
      this.products=response; //add GetAllProducts() response data to products array
  })
  }


}
