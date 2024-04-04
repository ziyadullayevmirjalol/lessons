using Cspace.Services;

namespace Cspace.ConsoleUI.SubMenu;

internal class BookingMenu
{
    private readonly BookingService _bookingService;
    public BookingMenu(BookingService bookingService)
    {
        _bookingService = bookingService;
    }
    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space / Bookings _______");
            Console.WriteLine(" 1. Create Booking");
            Console.WriteLine(" 2. Update Booking");
            Console.WriteLine(" 3. Delete Booking");
            Console.WriteLine(" 4. Get Booking by ID");
            Console.WriteLine(" 5. Get all Bookings\n");
            Console.WriteLine(" 6. Go Back to C-Scpace\n\n");

            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                //case "1":
                //    _userService.Create();
                //    break;
                //case "2":
                //    _userService.Update();
                //    break;
                //case "3":
                //    _userService.Delete();
                //    break;
                //case "4":
                //    _userService.GetByID();
                //    break;
                //case "5":
                //    _userService.GetAll();
                //    break;
                //case "6":
                //    Console.WriteLine("Press any key to confirm...");
                //    Console.ReadLine();

                //    loop = false;
                //    return;
            }
        }
    }
}
