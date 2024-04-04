using Task_Scheduler.Models;
using Task_Scheduler.Services;

namespace Task_Scheduler.ConsoleUI.SubMenu;

internal class ScheduleMenu
{
    private ScheduleService _scheduleService;
    public ScheduleMenu(ScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    public void Display()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Task Scheduler App / User");
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine(" 1. Create");
            Console.WriteLine(" 2. Update");
            Console.WriteLine(" 3. Delete");
            Console.WriteLine(" 4. Get all\n");
            Console.WriteLine(" 5. Exit...\n");

            Console.WriteLine("----------------------");
            Console.Write(" Enter Your Choice: ");
            var choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                CreateSchedule:
                    Console.Clear();

                    ScheduleModel CreateSchedule = new ScheduleModel();

                    Console.Write("Enter your Firstname: ");
                    CreateSchedule.Firstname = Console.ReadLine();
                    Console.Write("Enter your Lastname: ");
                    CreateSchedule.Lastname = Console.ReadLine();


                    ScheduleModel CreatedSchedule = _scheduleService.Create(CreateSchedule);
                    if (CreatedSchedule != null)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($" User ID: {CreatedSchedule.Id}");
                        Console.WriteLine($" User FIrstname: {CreatedSchedule.Firstname}");
                        Console.WriteLine($" User Lastname: {CreatedSchedule.Lastname}");
                        Console.WriteLine("----------------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" This user is not found. Press any key to re-enter");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        goto CreateSchedule;
                    }
                    break;
                case "2":
                UpdateSchedule:
                    Console.Clear();

                    ScheduleModel UpdateSchedule = new ScheduleModel();
                    Console.Write("Enter your ID: ");
                    UpdateSchedule.Id = int.Parse(Console.ReadLine());
                    Console.Write("Enter your Firstname: ");
                    UpdateSchedule.Firstname = Console.ReadLine();
                    Console.Write("Enter your Lastname: ");
                    UpdateSchedule.Lastname = Console.ReadLine();

                    ScheduleModel UpdatedUser = _scheduleService.Update(UpdateSchedule);
                    if (UpdatedUser != null)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($" User ID: {UpdatedUser.Id}");
                        Console.WriteLine($" User FIrstname: {UpdatedUser.Firstname}");
                        Console.WriteLine($" User Lastname: {UpdatedUser.Lastname}");
                        Console.WriteLine("----------------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" This user is not found. Press any key to re-enter");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        goto UpdateSchedule;
                    }
                    break;
                case "3":
                DeleteUser:
                    Console.Clear();


                    ScheduleModel DeleteUser = new ScheduleModel();
                    Console.Write("Enter your ID: ");
                    DeleteUser.Id = int.Parse(Console.ReadLine());

                    bool DeletedUser = _scheduleService.Delete(DeleteUser);
                    if (DeletedUser != false)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($" User with ID {DeleteUser.Id} deleted.");
                        Console.WriteLine("----------------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" This user is not found. Press any key to re-enter");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        goto DeleteUser;
                    }
                    break;
                case "4":
                    Console.Clear();

                    List<ScheduleModel> AllUsers = _scheduleService.GetAll();
                    if (AllUsers != null)
                    {
                        foreach (ScheduleModel user in AllUsers)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($" User ID: {user.Id}");
                            Console.WriteLine($" User FIrstname: {user.Firstname}");
                            Console.WriteLine($" User Lastname: {user.Lastname}");
                            Console.WriteLine("----------------------------------------\n");
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(" User list is empty. Press any key to go back");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                case "5":
                    Console.Clear();

                    Console.Write("Exit...");
                    Console.ReadLine();
                    loop = false;
                    break;
                default:
                    Console.Clear();

                    Console.Write("Wrong input. Press any key to re-enter...");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
