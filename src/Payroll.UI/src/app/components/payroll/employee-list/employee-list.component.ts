import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
})
export class EmployeeListComponent implements OnInit{

  constructor(public employeeService: EmployeeService) {  }

  ngOnInit(): void {
    //this.employeeService.getEmployeeList();
  }

}
