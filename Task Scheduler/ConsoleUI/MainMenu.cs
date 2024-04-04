using Task_Scheduler.ConsoleUI.SubMenu;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI;

internal class MainMenu
{
    private readonly ScheduleService scheduleService;
    private readonly TaskService taskService;

    private readonly ScheduleMenu scheduleMenu;
    private readonly TaskMenu taskMenu;

    public MainMenu()
    {
        this.scheduleService = new ScheduleService();
        this.taskService = new TaskService(scheduleService);

        this.scheduleMenu = new ScheduleMenu(scheduleService);
        this.taskMenu = new TaskMenu(scheduleService, taskService);
    }

    public void Display()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Task Scheduler App");
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine(" 1. Manage Schedules");
            Console.WriteLine(" 2. Manage Tasks");
            Console.WriteLine(" 3. Exit...\n");

            Console.WriteLine("----------------------");
            Console.Write(" Enter Your Choice: ");
            var choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    scheduleMenu.Display();
                    break;
                case "2":
                    taskMenu.Display();
                    break;
                case "3":
                    Console.Write("Exit...");
                    Console.ReadLine();
                    loop = false;
                    break;
                default:
                    Console.Write("Wrong input. Press any key to re-enter...");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
