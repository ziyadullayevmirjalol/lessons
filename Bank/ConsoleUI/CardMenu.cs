using Bank.ConsoleUI.Card;

namespace Bank.ConsoleUI;

public class CardMenu
{
    public void CardDisplay()
    {
        CardUI cardUI = new CardUI();

        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("------ Xalq Banki (Card Service Menu) ------\n");
            Console.WriteLine(" 1. Select for Create Card");
            Console.WriteLine(" 2. Select for Update Update");
            Console.WriteLine(" 3. Select for Delete Delete");
            Console.WriteLine(" 5. Select for Get all Cards");
            Console.WriteLine(" 4. Select for Get card by ID");
            Console.WriteLine(" 6. Select for Get all cards by CustomerID");
            Console.WriteLine(" 7. Select for Get all cards by Number");
            Console.WriteLine(" 8. Select for Get all cards by CardType");

            Console.WriteLine(" 9. Select to go back to main application menu\n");

            Console.Write("Enter your choise: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    cardUI.toCreate();
                    break;
                case "2":
                    cardUI.toUpdate();
                    break;
                case "3":
                    cardUI.toDelete();
                    break;
                case "4":
                    cardUI.toGetAll();
                    break;
                case "5":
                    cardUI.toGetByID();
                    break;
                case "6":
                    cardUI.toGetAllByCustomerID();
                    break;
                case "7":
                    cardUI.toGetAllByNumber();
                    break;
                case "8":
                    cardUI.toGetAllByCardType();
                    break;
                case "9":
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
