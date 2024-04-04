using Library_Managment.ConsoleUI.SubMenu;
using Library_Managment.Services;

namespace Library_Managment.ConsoleUI;

public class MainMenu
{
    public readonly BookService bookService;
    private readonly MemberService memberService;

    private readonly BookMenu bookMenu;
    private readonly MemberMenu memberMenu;
    public MainMenu()
    {
        this.bookService = new BookService();
        this.memberService = new MemberService(bookService);

        this.memberMenu = new MemberMenu(bookService, memberService);
        this.bookMenu = new BookMenu(memberService, bookService);
    }

    public void Display()
    {
        bool loop = true;
        while (loop)
        {


            Console.WriteLine("_____________ Library Managment System _____________");
            Console.WriteLine(" 1. Manage Books");
            Console.WriteLine(" 2. Manage Members");
            Console.WriteLine(" 3. Exit\n");

            Console.Write("Enter your chose: >>> ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    bookMenu.DisplayBook();
                    break;
                case "2":
                    memberMenu.DisplayMember();
                    break;
                case "3":
                    loop = false;
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong choose!\nPress any key to re-enter");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
