using Cspace.ConsoleUI.SubMenu;
using Cspace.Services;

namespace Cspace.ConsoleUI;


public class MainMenu
{
    private UserService userService;
    private PlaceService placeService;
    private FeatureService featureService;
    private BookingService bookingService;

    private readonly UserMenu _userMenu;
    private readonly PlaceMenu _placeMenu;
    private readonly FeatureMenu _featureMenu;
    private readonly BookingMenu _bookingMenu;

    public MainMenu()
    {
        userService = new UserService();
        placeService = new PlaceService();
        featureService = new FeatureService();
        bookingService = new BookingService(placeService, userService);

        _userMenu = new UserMenu(userService);
        _placeMenu = new PlaceMenu(placeService, featureService);
        _featureMenu = new FeatureMenu(featureService);
        _bookingMenu = new BookingMenu(bookingService);
    }

    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space _______");
            Console.WriteLine(" 1. Manage Users");
            Console.WriteLine(" 2. Manage Places");
            Console.WriteLine(" 3. Manage Features");
            Console.WriteLine(" 4. Manage Bookings\n");
            Console.WriteLine(" 5. Exit...\n\n");


            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    _userMenu.Display();
                    break;
                case "2":
                    _placeMenu.Display();
                    break;
                case "3":
                    _featureMenu.Display();
                    break;
                case "4":
                    _bookingMenu.Display();
                    break;
                case "5":
                    Console.WriteLine("Press any key to confirm...");
                    Console.ReadLine();

                    loop = false;
                    return;
            }
        }
    }
}
