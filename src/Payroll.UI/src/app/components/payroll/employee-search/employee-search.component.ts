import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EmployeeService } from '../../../services/employee.service';
import { Employee } from 'src/app/models/employee';

@Component({
  selector: 'app-employee-search',
  templateUrl: './employee-search.component.html',
  styleUrls: ['./employee-search.component.css'],
})
export class EmployeeSearchComponent implements OnInit {
  searchForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private employeeService: EmployeeService
  ) {
    this.searchForm = this.formBuilder.group({
      employeeId: ['', Validators.required],
    });
  }

  ngOnInit(): void {
  }

  getEmployeeData() {
    if (
      this.searchForm.value.employeeId === '' ||
      this.searchForm.value.employeeId === null
    ) {
      console.log('Employee ID is null - Get Employee List');
    } else {
      const employeeId: number = this.searchForm.value.employeeId;
      console.log('Employee ID: ' + employeeId);

      console.log('Getting Employee Data');
    }
  }
}
