using TicketSystem.Data.Entity;

namespace TicketSystem.Services
{
    public interface IDepartmentService
    {
        public List<Department> GetAllDepartments();
        void AddDepartment(Department newDepartment);
        void UpdateDepartment(Department updatedDepartment);
        void DeleteDepartment(int departmentId);
        Department GetDepartmentById(int departmentId);

    }
}
