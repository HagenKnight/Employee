using Moq;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;

namespace Payroll.Application.NUnit
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        [Test]
        public void AnualSalaryValueTest()
        {
            var _employeeService = new Mock<IEmployeeService<EmployeeDTO>>();
            /// Arrange
            var employee = new EmployeeDTO
            {
                Id = 1,
                employee_name = "Test",
                employee_age = 30,
                employee_salary = 1000,
                profile_image = ""
            };

            _employeeService.Setup(x => x.GetEmployeeAnualSalary(employee.employee_salary)).Returns(12000);

            /// Act
            var anualSalary = _employeeService.Object.GetEmployeeAnualSalary(employee.employee_salary);

            /// Assert
            Assert.That(anualSalary, Is.EqualTo(12000));
        }
      
    }
}