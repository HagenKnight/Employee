import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EmployeeService } from '../../../services/employee.service';
import { Employee } from 'src/app/models/employee';
import { ToastrService } from 'ngx-toastr';
import { PayrollComponent } from '../payroll.component';

@Component({
  selector: 'app-employee-search',
  templateUrl: './employee-search.component.html',
  styleUrls: ['./employee-search.component.css'],
})
export class EmployeeSearchComponent implements OnInit {
  searchForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private employeeService: EmployeeService,
    private payrollComponent: PayrollComponent,
    private toastr: ToastrService
  ) {
    this.searchForm = this.formBuilder.group({
      employeeId: ['', Validators.required],
    });
  }

  ngOnInit(): void {}

  getEmployeeData() {
    if (
      this.searchForm.value.employeeId === '' ||
      this.searchForm.value.employeeId === null
    ) {
      console.log('Employee ID is null - Get Employee List');
      this.employeeService.getEmployeeList().subscribe(
        (data: Employee[]) => {
          console.log({ data });
          this.payrollComponent.showEmployeeCard = false;
          this.payrollComponent.showEmployeeList = true;
          this.employeeService.employeeList = data;
          this.toastr.success('Request successfully processed', 'Success');
        },
        ({status, error}) => {

          this.payrollComponent.showEmployeeList = false;
          console.log("code: " + status);
          console.log({error});
          if(status === 429) {
            this.toastr.error(`${error.message}`, 'Error');
          }
          else if (status === 404) {
            this.toastr.warning(`${error.message}`, 'Warning');
          }
          else  if (status === 400) {
            this.toastr.error(`${error.title}`, 'Bad Request');
          }
        }
      );
    } else {
      const employeeId: number = this.searchForm.value.employeeId;
      console.log('Employee ID: ' + employeeId);

      this.employeeService.getEmployeeData(employeeId).subscribe(
        (data: Employee) => {
          console.log({ data });
          this.payrollComponent.showEmployeeCard = true;
          this.payrollComponent.showEmployeeList = false;
          this.employeeService.employeeData = data;
          this.toastr.success('Request successfully processed', 'Success');
        },
        ({status, error}) => {

          this.payrollComponent.showEmployeeList = false;
          console.log("code: " + status);
          console.log({error});
          if(status === 429) {
            this.toastr.error(`${error.message}`, 'Error');
          }
          else if (status === 404) {
            this.toastr.warning(`${error.message}`, 'Warning');
          }
          else  if (status === 400) {
            this.toastr.error(`${error.title}`, 'Bad Request');
          }
        }
      );
    }
  }
}
