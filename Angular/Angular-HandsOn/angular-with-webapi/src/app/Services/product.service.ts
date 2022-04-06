import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Product } from '../Models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  product_api=environment.product_api;
  constructor(private http:HttpClient) { }
  //Get All the products
  GetAllProducts():Observable<Product[]>
  {
    //invoking the api endpoint and returns data in product array
    return this.http.get<Product[]>(this.product_api+'GetProducts')
  }
  //Get Product using Id
  GetById(id:number):Observable<Product>
  {
    return this.http.get<Product>(this.product_api+'GetProductById/'+id);
  }
  //Add Products
  AddProduct(item:Product):Observable<string>
  {
    return this.http.post<string>(this.product_api+'AddProduct',item);
  }
  //Delete Product By Id
  DeleteProduct(id:number):Observable<any>
  {
    return this.http.delete(this.product_api+'DeleteProduct/'+id);
  }
   //Edit Products
   EditProduct(item:Product):Observable<any>
   {
     return this.http.put(this.product_api+'EditProduct',item);
   }

}
