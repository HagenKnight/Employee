import { NgModule } from '@angular/core';
import { CommonModule, registerLocaleData } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import localeFr from '@angular/common/locales/de';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PayrollComponent } from './components/payroll/payroll.component';
import { EmployeeListComponent } from './components/payroll/employee-list/employee-list.component';
import { EmployeeCardComponent } from './components/payroll/employee-card/employee-card.component';
import { EmployeeSearchComponent } from './components/payroll/employee-search/employee-search.component';
import { FooterComponent } from './components/footer/footer.component';


registerLocaleData(localeFr, 'de');
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
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
