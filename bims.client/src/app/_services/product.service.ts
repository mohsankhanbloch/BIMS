import { Inject, inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  baseurl: string = environment.apiURL;

  constructor(private http: HttpClient) {  }

  getProducts() {
    return this.http.get<any>(this.baseurl + '/api/product')
      .pipe(map(response => {
        return response;
      }));
  }

}
