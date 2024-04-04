using Cspace.Models;
using Cspace.Services;

namespace Cspace.ConsoleUI.SubMenu;

internal class PlaceMenu
{
    private readonly PlaceService _placeService;
    private readonly FeatureService _featureService;
    public PlaceMenu(PlaceService placeService, FeatureService featureService)
    {
        _placeService = placeService;
        _featureService = featureService;
    }
    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space / Places _______");
            Console.WriteLine(" 1. Create Place");
            Console.WriteLine(" 2. Update Place");
            Console.WriteLine(" 3. Delete Place");
            Console.WriteLine(" 4. Get Place by ID");
            Console.WriteLine(" 5. Get all Places\n");
            Console.WriteLine(" 6. Go Back to C-Scpace\n\n");

            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    string cNumber = string.Empty;
                    int cFloor = 0;
                    string cRoom = string.Empty;
                    decimal cPrice = 0;

                    Console.Write("Enter Place's Floor: ");
                    cFloor = int.Parse(Console.ReadLine());
                    Console.Write("Enter Place's Room: ");
                    cRoom = Console.ReadLine();
                    Console.Write("Enter Place's Number: ");
                    cNumber = Console.ReadLine();
                    Console.Write("Enter Place's Features: ");

                    foreach (Feature feature in _featureService.GetAll())
                    {
                        Console.WriteLine($"Feature Id: {feature.Id}, Name: {feature.Name}");
                    }
                    var cFeatureChoise = int.Parse(Console.ReadLine());
                    foreach (Feature feature in _featureService.GetAll())
                    {
                        if (feature.Id == cFeatureChoise)
                        {

                        }
                    }
                    Console.Write("Enter Place's Price: ");
                    cPrice = decimal.Parse(Console.ReadLine());

                    Place CnewPlace = new Place();
                    CnewPlace.Number = cNumber;

                    try
                    {
                        var createdFreature = _placeService.Create(CnewPlace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("Feature Created!");
                    break;
                case "2":
                    int uId = 0;
                    string uNumber = string.Empty;

                    Console.Write("Enter Place's ID: ");
                    uId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Place's Name: ");
                    uNumber = Console.ReadLine();

                    Place updatePlace = new Place();
                    updatePlace.Id = uId;
                    updatePlace.Number = uNumber;

                    try
                    {
                        var updatedFeature = _placeService.Update(updatePlace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    int dId = 0;

                    Console.Write("Enter Place's ID: ");
                    uId = int.Parse(Console.ReadLine());

                    Place dnewPlace = new Place();
                    dnewPlace.Id = uId;

                    var deletedUser = _placeService.Delete(dnewPlace);
                    if (deletedUser == false)
                    {
                        Console.WriteLine("This place is not found");
                    }
                    else
                    {
                        Console.WriteLine("Place Deleted Successfully");
                    }

                    break;
                case "4":
                    int gId = 0;

                    Console.Write("Enter Place's ID: ");
                    uId = int.Parse(Console.ReadLine());

                    Place gotPlace = _placeService.GetByID(gId);
                    if (gotPlace == null)
                    {
                        Console.WriteLine("This place is not found");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"Place's Number: {gotPlace.Number}");
                        Console.WriteLine($"Place's Room: {gotPlace.Room}");
                        Console.WriteLine($"Place's Floor: {gotPlace.Floor}");
                        Console.WriteLine($"Place's Features: {gotPlace.Features}");
                        Console.WriteLine($"Place's Price: {gotPlace.Price}");
                        Console.WriteLine($"Place's IsAvailable: {gotPlace.IsAvailable}");
                        Console.WriteLine("---------------------------------------------\n");
                    }

                    break;
                case "5":
                    foreach (Place place in _placeService.GetAll())
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"Place's Number: {place.Number}");
                        Console.WriteLine($"Place's Room: {place.Room}");
                        Console.WriteLine($"Place's Floor: {place.Floor}");
                        Console.WriteLine($"Place's Features: {place.Features}");
                        Console.WriteLine($"Place's Price: {place.Price}");
                        Console.WriteLine($"Place's IsAvailable: {place.IsAvailable}");
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
