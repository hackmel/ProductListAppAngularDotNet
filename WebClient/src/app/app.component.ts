import { Component } from '@angular/core';
import { Product } from '../app/models/product'
import {ProductService} from '../app/services/product.service';
import { Observable } from 'rxjs';
import { rendererTypeName } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  products: Product[];

  constructor(productService: ProductService) {
    productService.getProducts()
    .subscribe(res => {
      this.products =  res['products'];
    });
  }
}
