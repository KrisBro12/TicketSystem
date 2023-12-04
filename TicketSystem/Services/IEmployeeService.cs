using TicketSystem.Data.Entity;
public interface IEmployeeService
{
    List<Employee> GetAllEmployees();
    void AddEmployee(Employee newEmployee);
    void UpdateEmployee(Employee updatedEmployee);
    void DeleteEmployee(int employeeId);
    Employee GetEmployeeById(int employeeId);
}
