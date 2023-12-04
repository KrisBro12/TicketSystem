using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Data.Entity;
using TicketSystem.Services;

public class EmployeeService : IEmployeeService
{
    private readonly ApplicationDbContext applicationDbContext;

    public EmployeeService(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }

    public List<Employee> GetAllEmployees()
    {
        return applicationDbContext.employee.Include(e => e.department).ToList();
    }

    public void AddEmployee(Employee newEmployee)
    {
        try
        {
            applicationDbContext.employee.Add(newEmployee);
            applicationDbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding employee: {ex.Message}");
        }
    }

    public void UpdateEmployee(Employee updatedEmployee)
    {
        try
        {
            applicationDbContext.Entry(updatedEmployee).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating employee: {ex.Message}");
        }
    }

    public void DeleteEmployee(int employeeId)
    {
        try
        {
            var employeeToDelete = applicationDbContext.employee.Find(employeeId);

            if (employeeToDelete != null)
            {
                applicationDbContext.employee.Remove(employeeToDelete);
                applicationDbContext.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting employee: {ex.Message}");
        }
    }

    public TicketSystem.Data.Entity.Employee GetEmployeeById(int employeeId)
    {
        return applicationDbContext.employee.Find(employeeId);
    }

}
