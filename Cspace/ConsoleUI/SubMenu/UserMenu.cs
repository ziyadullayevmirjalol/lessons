using Cspace.Models;
using Cspace.Services;

namespace Cspace.ConsoleUI.SubMenu;

internal class UserMenu
{
    private readonly UserService _userService;
    public UserMenu(UserService userService)
    {
        _userService = userService;
    }
    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space / Users _______");
            Console.WriteLine(" 1. Create User");
            Console.WriteLine(" 2. Update User");
            Console.WriteLine(" 3. Delete User");
            Console.WriteLine(" 4. Get User by ID");
            Console.WriteLine(" 5. Get all Users\n");
            Console.WriteLine(" 6. Go Back to C-Space\n\n");

            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    string cFirstName = string.Empty;
                    string cLastName = string.Empty;
                    string cPhone = string.Empty;
                    string cemail = string.Empty;
                    Console.Write("Enter Your Firstname: ");
                    cFirstName = Console.ReadLine();
                    Console.Write("Enter Your Lastname: ");
                    cLastName = Console.ReadLine();
                    Console.Write("Enter Your Phone: ");
                    cPhone = Console.ReadLine();
                    Console.Write("Enter Your Email: ");
                    cemail = Console.ReadLine();

                    User CnewUser = new User();
                    CnewUser.FirstName = cFirstName;
                    CnewUser.LastName = cLastName;
                    CnewUser.Phone = cPhone;
                    CnewUser.Email = cemail;

                    try
                    {
                        var createdUser = _userService.Create(CnewUser);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("User Created!");

                    break;
                case "2":
                    int uId = 0;
                    string uFirstName = string.Empty;
                    string uLastName = string.Empty;
                    string uPhone = string.Empty;
                    string uEmail = string.Empty;
                    Console.Write("Enter Your Firstname: ");
                    uFirstName = Console.ReadLine();
                    Console.Write("Enter Your Lastname: ");
                    uLastName = Console.ReadLine();
                    Console.Write("Enter Your Phone: ");
                    uPhone = Console.ReadLine();
                    Console.Write("Enter Your Email: ");
                    uEmail = Console.ReadLine();

                    User UnewUser = new User();
                    UnewUser.Id = uId;
                    UnewUser.FirstName = uFirstName;
                    UnewUser.LastName = uLastName;
                    UnewUser.Phone = uPhone;
                    UnewUser.Email = uEmail;

                    try
                    {
                        var updatedUser = _userService.Update(UnewUser);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                case "3":
                    int dId = 0;

                    Console.Write("Enter Your ID: ");
                    uId = int.Parse(Console.ReadLine());

                    User dnewUser = new User();
                    dnewUser.Id = uId;

                    var deletedUser = _userService.Delete(dnewUser);
                    if (deletedUser == false)
                    {
                        Console.WriteLine("This user is not found");
                    }
                    else
                    {
                        Console.WriteLine("User Deleted Successfully");
                    }

                    break;
                case "4":
                    int gId = 0;

                    Console.Write("Enter an ID: ");
                    uId = int.Parse(Console.ReadLine());

                    var gotUser = _userService.GetByID(gId);
                    if (gotUser == null)
                    {
                        Console.WriteLine("This user is not found");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"User's Firstname: {gotUser.FirstName}");
                        Console.WriteLine($"User's Lastname: {gotUser.LastName}");
                        Console.WriteLine($"User's Phone: {gotUser.Phone}");
                        Console.WriteLine($"User's Email: {gotUser.Email}");
                        Console.WriteLine("---------------------------------------------\n");

                    }

                    break;
                case "5":
                    foreach (User item in _userService.GetAll())
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"User's ID: {item.Id}");
                        Console.WriteLine($"User's FirstName: {item.FirstName}");
                        Console.WriteLine($"User's LastName: {item.LastName}");
                        Console.WriteLine($"User's Phone: {item.Phone}");
                        Console.WriteLine($"User's Email: {item.Email}");
                        Console.WriteLine("---------------------------------------------\n");
                    }

                    break;
                case "6":
                    Console.WriteLine("Press any key to confirm...");
                    Console.ReadLine();

                    loop = false;
                    return;
            }
        }
    }
}
