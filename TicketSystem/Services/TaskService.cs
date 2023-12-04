using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Data.Entity;

namespace TicketSystem.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public TaskService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<Data.Entity.Task> GetAllTasks()
        {
            return applicationDbContext.task.ToList();
        }

        public void AddTask(Data.Entity.Task newTask)
        {
            try
            {
                applicationDbContext.task.Add(newTask);
                applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error adding task: {ex.Message}");
            }
        }

        public void UpdateTask(Data.Entity.Task updatedTask)
        {
            try
            {
                applicationDbContext.Entry(updatedTask).State = EntityState.Modified;
                applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error updating task: {ex.Message}");
            }
        }

        public void DeleteTask(int taskId)
        {
            try
            {
                var taskToDelete = applicationDbContext.task.Find(taskId);

                if (taskToDelete != null)
                {
                    applicationDbContext.task.Remove(taskToDelete);
                    applicationDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                Console.WriteLine($"Error deleting task: {ex.Message}");
            }
        }
        // Implement the additional method to get a task by ID
        public TicketSystem.Data.Entity.Task GetTaskById(int taskId)
        {
            return applicationDbContext.task.Find(taskId);
        }
    }
}
