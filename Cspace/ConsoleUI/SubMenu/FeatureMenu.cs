using Cspace.Models;
using Cspace.Services;

namespace Cspace.ConsoleUI.SubMenu;

public class FeatureMenu
{
    private readonly FeatureService _featureService;
    public FeatureMenu(FeatureService featureService)
    {
        _featureService = featureService;
    }
    public void Display()
    {
        var loop = true;
        while (loop)
        {
            Console.WriteLine("_______ C-Space / Features _______");
            Console.WriteLine(" 1. Create Feature");
            Console.WriteLine(" 2. Update Feature");
            Console.WriteLine(" 3. Delete Feature");
            Console.WriteLine(" 4. Get Feature by ID");
            Console.WriteLine(" 5. Get all Features\n");
            Console.WriteLine(" 6. Go Back to C-Space\n\n");

            Console.Write("Enter your choise: ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    string cName = string.Empty;

                    Console.Write("Enter Feature's Name: ");
                    cName = Console.ReadLine();

                    Feature CnewFeature = new Feature();
                    CnewFeature.Name = cName;

                    try
                    {
                        var createdFreature = _featureService.Create(CnewFeature);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("Feature Created!");
                    break;
                case "2":
                    int uId = 0;
                    string uName = string.Empty;

                    Console.Write("Enter Feature's ID: ");
                    uId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Feature's Name: ");
                    uName = Console.ReadLine();

                    Feature updateFeature = new Feature();
                    updateFeature.Id = uId;
                    updateFeature.Name = uName;

                    try
                    {
                        var updatedFeature = _featureService.Update(updateFeature);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    int dId = 0;

                    Console.Write("Enter Feature's ID: ");
                    uId = int.Parse(Console.ReadLine());

                    Feature dnewFeature = new Feature();
                    dnewFeature.Id = uId;

                    var deletedUser = _featureService.Delete(dnewFeature);
                    if (deletedUser == false)
                    {
                        Console.WriteLine("This feature is not found");
                    }
                    else
                    {
                        Console.WriteLine("Feature Deleted Successfully");
                    }

                    break;
                case "4":
                    int gId = 0;

                    Console.Write("Enter Feature's ID: ");
                    uId = int.Parse(Console.ReadLine());

                    var gotFeature = _featureService.GetByID(gId);
                    if (gotFeature == null)
                    {
                        Console.WriteLine("This feature is not found");
                    }
                    else
                    {
                        Console.WriteLine($"Feature's Name: {gotFeature}");
                    }

                    break;
                case "5":
                    _featureService.GetAll();
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
