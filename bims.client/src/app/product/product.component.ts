import { Component, OnInit } from '@angular/core';
import { ProductService } from '../_services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  data: any[] = [];
  constructor(private _productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }



  getProducts() {
    this._productService.getProducts().subscribe((data: any) => {
      debugger;
      if (data.code == "00") {
        this.data = data.data;
      } else {
        this.data = [];
      }

    }, (_error: any) => {

    })
  }


}
