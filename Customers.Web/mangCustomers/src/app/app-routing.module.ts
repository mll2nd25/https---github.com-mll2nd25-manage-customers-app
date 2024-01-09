import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {MangCustomersComponent} from './mang-customers/mang-customers.component';

const routes: Routes = [{ path: '', component: MangCustomersComponent, pathMatch: 'full' }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
