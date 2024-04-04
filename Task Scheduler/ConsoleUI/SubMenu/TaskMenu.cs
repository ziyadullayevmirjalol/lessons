using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI.SubMenu;

internal class TaskMenu
{
    private ScheduleService _userService;
    private TaskService _taskService;
    public TaskMenu(ScheduleService userService, TaskService taskService)
    {
        _userService = userService;
        _taskService = taskService;
    }

    public void Display()
    {

    }
}
