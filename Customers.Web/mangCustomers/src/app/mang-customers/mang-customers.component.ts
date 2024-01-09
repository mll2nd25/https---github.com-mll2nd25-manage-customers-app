import { Component, Renderer2, ElementRef } from '@angular/core';
import { CustomerService } from '../../services/customer/customer.service';
import { Customer } from '../../models/customer/customer.model';

@Component({
  selector: 'app-mang-customers',
  templateUrl: './mang-customers.component.html',
  styleUrls: ['./mang-customers.component.css']
})
export class MangCustomersComponent {

  constructor(private customerSrv: CustomerService, private renderer: Renderer2, private el: ElementRef) { }

  public customers: any;

  customer = {

    firstName: '',
    lastName: '',
    email: '',
    isActive: true,
    createdDT: new Date()

  };

  selectedRowIndex: number = -1;

  highlight(row: any) {
    this.selectedRowIndex = row;
  }

  async ngOnInit() {

    await this.getCustomers();
  }

  private async getCustomers() {

    this.customers = await this.customerSrv.getCustomers();
  }

  private viewCustomer(Id: any) {

    this.addClassByAttribute('id', `edit_${Id}`, 'user-edit-info');
    this.removeClassByAttribute('id', `ro_${Id}`, 'user-edit-info');
    this.addClassByAttribute('id', `ro_${Id}`, 'user-readonly-info');
  }

  private removeClass(id: any) {
    const element = this.el.nativeElement.querySelector(id);
    this.renderer.removeClass(element, 'user-edit-info');
  }

  private removeClassByAttribute(attribute: string, value: string, className: string) {
    const elements = this.el.nativeElement.querySelectorAll(`[${attribute}="${value}"]`);
    elements.forEach((element: any) => {
      this.renderer.removeClass(element, className);
    });
  }

  private addClassByAttribute(attribute: string, value: string, className: string) {
    const elements = this.el.nativeElement.querySelectorAll(`[${attribute}="${value}"]`);
    elements.forEach((element: any) => {
      this.renderer.addClass(element, className);
    });
  }

  private reset() {

    this.customer.firstName = '';
    this.customer.lastName = '';
    this.customer.email = '';
  }

  private validate(obj: any) {

    const emailRegex = /^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$/;

    if (obj.firstName == '' || obj.lastName == '' || (obj.email == '' || !emailRegex.test(obj.email))) return false;
    else return true;
  }

  public async editCustomer(arg: any) {

    this.removeClassByAttribute('id', `edit_${arg}`, 'user-edit-info');
    this.removeClassByAttribute('id', `ro_${arg}`, 'user-readonly-info');
    this.addClassByAttribute('id', `ro_${arg}`, 'user-edit-info');
  }
  public async create(obj: any) {

    if (this.validate(obj)) {

      this.customers = await this.customerSrv.addCustomers(obj);

      this.reset();
    }
  }
  public async edit(Id: any, obj: any) {

    if (this.validate(obj)) {

      obj.updatedDT = new Date();

      await this.customerSrv.updateCustomer(obj);

      this.viewCustomer(Id);
    }
  }
  public async cancel(Id: any) {

    this.viewCustomer(Id);
  }
}
