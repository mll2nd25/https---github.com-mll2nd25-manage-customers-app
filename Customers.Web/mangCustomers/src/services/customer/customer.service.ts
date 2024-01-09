import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  async addCustomers(obj: any) {

    const url = 'http://localhost:5093/api/Customer/AddCustomer';
    const data = await this.http.post(url, obj).toPromise();
    return data;
  }

  async getCustomers() {
    const url = 'http://localhost:5093/api/Customer/GetCustomers';
    const data = await this.http.get(url).toPromise();
    return data;
  }

  async updateCustomer(obj: any) {
    const url = 'http://localhost:5093/api/Customer/UpdateCustomer';
    await this.http.put(url, obj).toPromise();
  }
}
