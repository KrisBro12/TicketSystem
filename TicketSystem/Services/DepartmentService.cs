using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Data.Entity;

namespace TicketSystem.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public DepartmentService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        
        public List<Department> GetAllDepartments()
        {
            return applicationDbContext.department.ToList();
        }

        public void AddDepartment(Department newDepartment)
        {
            try
            {
                applicationDbContext.department.Add(newDepartment);
                applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error adding department: {ex.Message}");
            }
        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                applicationDbContext.Entry(updatedDepartment).State = EntityState.Modified;
                applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error updating department: {ex.Message}");
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            try
            {
                var departmentToDelete = applicationDbContext.department.Find(departmentId);

                if (departmentToDelete != null)
                {
                    applicationDbContext.department.Remove(departmentToDelete);
                    applicationDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error deleting department: {ex.Message}");
            }
        }
        // Implement the additional method to get a department by ID
        public TicketSystem.Data.Entity.Department GetDepartmentById(int departmentId)
        {
            return applicationDbContext.department.Find(departmentId);
        }
    }
}
