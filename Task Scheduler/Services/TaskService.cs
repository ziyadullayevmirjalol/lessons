using Task_Scheduler.Interfaces;
using Task_Scheduler.Models;

namespace Task_Scheduler.Services;

public class TaskService : ITaskService
{
    List<TaskModel> _tasks;
    ScheduleService _userService;
    public TaskService(ScheduleService userService)
    {
        _tasks = new List<TaskModel>();
        _userService = userService;
    }
    public TaskModel Create(TaskModel task)
    {
        ScheduleModel user = null;
        foreach (ScheduleModel item in _userService.GetAll())
        {
            if (item.Id == task.UserID)
            {
                user = item;
                break;
            }
        }
        if (user == null)
        {
            throw new Exception("User not found.");
        }
        task.Id = _tasks.Count + 1;
        _tasks.Add(task);

        return task;
    }

    public bool Delete(TaskModel task)
    {
        bool found = false;
        foreach (TaskModel item in _tasks)
        {
            if (task.Id == item.Id)
            {

                found = true;
                _tasks.Remove(item);
                break;
            }
        }
        return found;
    }

    public List<TaskModel> GetAll()
    {
        return _tasks;
    }

    public (List<TaskModel> Todo, List<TaskModel> Completed) GetByUserID(int id)
    {
        List<TaskModel> Todo = new List<TaskModel>();
        List<TaskModel> Completed = new List<TaskModel>();

        foreach (TaskModel item in _tasks)
        {
            if (item.Status == true)
            {
                Completed.Add(item);
            }
            else
            {
                Todo.Add(item);
            }
        }
        return (Todo, Completed);
    }

    public TaskModel Update(TaskModel task)
    {
        TaskModel found = null;
        foreach (TaskModel item in _tasks)
        {
            if (item.Id == task.Id)
            {
                item.Title = task.Title;
                item.Description = task.Description;
                found = item;
            }
        }
        return found;
    }
}
