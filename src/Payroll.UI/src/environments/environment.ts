import { environment as config } from "src/config/config";

export const environment = {
  production: false,
  apiUrl: config.apiUrl,
  employeeEndpoint: config.employeeEndpoint
}
