using Bank.ConsoleUI.Customer;

namespace Bank.ConsoleUI;

public class CustomerMenu
{
    public void CustomerDisplay()
    {
        CustomerUI customerUI = new CustomerUI();

        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("------ Xalq Banki (Customer Service Menu) ------\n");
            Console.WriteLine(" 1. Select for Create Customer");
            Console.WriteLine(" 2. Select for Update Customer");
            Console.WriteLine(" 3. Select for Delete Customer");
            Console.WriteLine(" 4. Select for Get customer by ID");
            Console.WriteLine(" 5. Select for Get all customers");

            Console.WriteLine(" 6. Select to go back to main application menu\n");

            Console.Write("Enter your choise: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    customerUI.toCreate();
                    break;
                case "2":
                    customerUI.toUpdate();
                    break;
                case "3":
                    customerUI.toDelete();
                    break;
                case "4":
                    customerUI.toGetByID();
                    break;
                case "5":
                    customerUI.toGetAll();
                    break;
                case "6":
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
