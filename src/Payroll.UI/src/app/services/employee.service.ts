import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  employeeAppUrl = environment.apiUrl;
  employeeApiUrl = environment.employeeEndpoint;
  employeeList: Employee[] = [];
  employeeData : Employee = new Employee();

  constructor(private http: HttpClient) {}

  getEmployeeData(employeeId: number): Observable<Employee> {
    return this.http.get<Employee>(
      `${this.employeeAppUrl}${this.employeeApiUrl}${employeeId}`,
      { responseType: 'json' }
    );
  }

  getEmployeeList(): Observable<Employee[]> {
    return this.http.get<Employee[]>(
      `${this.employeeAppUrl}${this.employeeApiUrl}`,
      { responseType: 'json' }
    );
  }
}
