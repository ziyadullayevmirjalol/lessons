using Task_Scheduler.Models;

namespace Task_Scheduler.Interfaces;

public interface ITaskService
{
    TaskModel Create(TaskModel task);
    TaskModel Update(TaskModel task);
    bool Delete(TaskModel task);
    List<TaskModel> GetAll();
    (List<TaskModel> Todo, List<TaskModel> Completed) GetByUserID(int id);
}
