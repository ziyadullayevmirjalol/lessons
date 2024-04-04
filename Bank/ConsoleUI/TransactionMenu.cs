using Bank.ConsoleUI.Transaction;

namespace Bank.ConsoleUI;

public class TransactionMenu
{
    public void TransactionDisplay()
    {
        TransactionUI transactionUI = new TransactionUI();

        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("------ Xalq Banki (Transaction Service Menu) ------\n");
            Console.WriteLine(" 1. Select for Create Transaction");
            Console.WriteLine(" 2. Select for Get transaction by ID");
            Console.WriteLine(" 3. Select for Get all transactions by CardID");
            Console.WriteLine(" 4. Select for Get all transactions by CustomerID");
            Console.WriteLine(" 5. Select for Get all transactions by Type");

            Console.WriteLine(" 6. Select to go back to main application menu\n");

            Console.Write("Enter your choise: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    transactionUI.toCreate();
                    break;
                case "2":
                    transactionUI.toGetByID();
                    break;
                case "3":
                    transactionUI.toGetAllByCardID();
                    break;
                case "4":
                    transactionUI.toGetAllByCustomerID();
                    break;
                case "5":
                    TransactionUI.toGetAllByType();
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
