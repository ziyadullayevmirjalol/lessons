namespace Bank.ConsoleUI;

public class Menu
{
    public void Display()
    {
        EmployeeMenu employeeMenu = new EmployeeMenu();
        CustomerMenu customerMenu = new CustomerMenu();
        CardMenu cardMenu = new CardMenu();
        TransactionMenu transactionMenu = new TransactionMenu();

        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("------ Xalq Banki (Console Application) ------\n");
            Console.WriteLine(" 1. Select for Customers Service");
            Console.WriteLine(" 2. Select for Employees Service");
            Console.WriteLine(" 3. Select for Cards Service");
            Console.WriteLine(" 4. Select for Transactions Service");
            Console.WriteLine(" 5. Select to exit from Console App\n");

            Console.Write("Enter your choise: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Console.Clear();
                    customerMenu.CustomerDisplay();

                    break;
                case "2":
                    Console.Clear();
                    employeeMenu.EmployeeDisplay();

                    break;
                case "3":
                    Console.Clear();
                    cardMenu.CardDisplay();

                    break;
                case "4":
                    Console.Clear();
                    transactionMenu.TransactionDisplay();

                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Exit...");
                    System.Threading.Thread.Sleep(500);
                    loop = false;
                    break;
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
