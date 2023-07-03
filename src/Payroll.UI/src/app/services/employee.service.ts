import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})

export class EmployeeService {
  employeeAppUrl = 'https://localhost:7107';
  employeeApiUrl = 'api/employee/';
  employeeList: Employee[] = [];

  constructor(private http: HttpClient) {}

  getEmployeeData(employeeId: number): Observable<Employee> {
    return this.http.get<Employee>(
      `${this.employeeAppUrl}${this.employeeApiUrl}${employeeId}`,
      { responseType: 'json' }
    );
  }

  getEmployeeList(): Observable<Employee[]> {
     return this.http.get<Employee[]>(`${this.employeeAppUrl}${this.employeeApiUrl}`)
  }
}
