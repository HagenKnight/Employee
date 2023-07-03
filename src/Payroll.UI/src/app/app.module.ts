import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PayrollComponent } from './components/payroll/payroll.component';
import { EmployeeListComponent } from './components/payroll/employee-list/employee-list.component';
import { EmployeeCardComponent } from './components/payroll/employee-card/employee-card.component';
import { EmployeeSearchComponent } from './components/payroll/employee-search/employee-search.component';
import { FooterComponent } from './components/footer/footer.component';


@NgModule({
  declarations: [
    AppComponent,
    PayrollComponent,
    EmployeeListComponent,
    EmployeeCardComponent,
    EmployeeSearchComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
