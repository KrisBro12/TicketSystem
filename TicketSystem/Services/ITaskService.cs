using TicketSystem.Data.Entity;

namespace TicketSystem.Services
{
    public interface ITaskService
    {
        public List<Data.Entity.Task> GetAllTasks();
        void AddTask(Data.Entity.Task newTask);
        void UpdateTask(Data.Entity.Task updatedTask);
        void DeleteTask(int taskId);
        Data.Entity.Task GetTaskById(int taskId);

    }
}
