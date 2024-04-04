using Bank.ConsoleUI.Employee;

namespace Bank.ConsoleUI;

public class EmployeeMenu
{
    public void EmployeeDisplay()
    {
        EmployeeUI employeeUI = new EmployeeUI();

        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("------ Xalq Banki (Employee Service Menu) ------\n");
            Console.WriteLine(" 1. Select for Create Employee");
            Console.WriteLine(" 2. Select for Update Emoloyee");
            Console.WriteLine(" 3. Select for Delete Emoloyee");
            Console.WriteLine(" 4. Select for Get emoloyee by ID");
            Console.WriteLine(" 5. Select for Get all employees");
            Console.WriteLine(" 6. Select for Get all employees by Position");
            Console.WriteLine(" 7. Select for Get all employees by PassportNumber");

            Console.WriteLine(" 8. Select to go back to main application menu\n");

            Console.Write("Enter your choise: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    employeeUI.toCreate();
                    break;
                case "2":
                    employeeUI.toUpdate();
                    break;
                case "3":
                    employeeUI.toDelete();
                    break;
                case "4":
                    employeeUI.toGetByID();
                    break;
                case "5":
                    employeeUI.toGetAll();
                    break;
                case "6":
                    employeeUI.toGetByPosition();
                    break;
                case "7":
                    employeeUI.toGetByPassportNumber();
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("Main Menu");
                    System.Threading.Thread.Sleep(500);
                    loop = false;

                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choose...\n");
                    Console.WriteLine("Press any key to re-enter...");
                    Console.ReadLine();

                    continue;
            }
        }
    }
}
