using Bank.Interfaces;
using Bank.Models;

namespace Bank.ConsoleUI.Customer;

public class CustomerUI
{
    ICustomerService customerService;
    public void toCreate()
    {
        string Cfirstname = string.Empty;
        string Clastname = string.Empty;
        string Cphone = string.Empty;
        DateTime Cdateofbirth = DateTime.MinValue;

        Console.Clear();

        Console.WriteLine("------ (Customer Service Menu) Create Customer ------\n");
        Console.Write("Enter your Firstname: ");
        Cfirstname = Console.ReadLine();

        Console.Write("Enter your Lastname: ");
        Clastname = Console.ReadLine();

        Console.Write("Enter your Phone number: ");
        Cphone = Console.ReadLine();

        Console.Write("Enter you date of birth: ");
        Cdateofbirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        CustomerModel customer = new CustomerModel();
        customer.FirstName = Cfirstname;
        customer.LastName = Clastname;
        customer.Phone = Cphone;
        customer.DateOfBirth = Cdateofbirth;
        customerService.Create(customer);
    }
    public void toUpdate()
    {
        string Ufirstname = string.Empty;
        string Ulastname = string.Empty;
        string Uphone = string.Empty;
        DateTime Udateofbirth = DateTime.MinValue;

        Console.Clear();

        Console.WriteLine("------ (Customer Service Menu) Update Customer ------\n");
        Console.Write("Enter your Firstname: ");
        Ufirstname = Console.ReadLine();

        Console.Write("Enter your Lastname: ");
        Ulastname = Console.ReadLine();

        Console.Write("Enter your Phone number: ");
        Uphone = Console.ReadLine();

        Console.Write("Enter you date of birth: ");
        Udateofbirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        CustomerModel customer = new CustomerModel();
        customer.FirstName = Ufirstname;
        customer.LastName = Ulastname;
        customer.Phone = Uphone;
        customer.DateOfBirth = Udateofbirth;

        customerService.Update(customer);
    }
    public void toDelete()
    {
        Console.Clear();

        int Did = 0;

        Console.WriteLine("------ (Customer Service Menu) Delete Customer ------\n");
        Console.WriteLine(" Enter an ID: ");
        string stringID = Console.ReadLine();
        if (stringID != "")
        {
            Did = int.Parse(stringID);
        }
        var found = customerService.Delete(Did);
        if (found == false)
        {
            Console.WriteLine($"Customer with ID {Did} not found!");
        }
    }
    public void toGetByID()
    {
        Console.Clear();

        int Did = 0;

        Console.WriteLine("------ (Customer Service Menu) Get Customer by ID ------\n");
        Console.WriteLine(" Enter an ID: ");
        string stringID = Console.ReadLine();
        if (stringID != "")
        {
            Did = int.Parse(stringID);
        }
        CustomerModel found = customerService.GetByID(Did);
        if (found != null)
        {
            Console.WriteLine($"Customer's Firstname is {found.FirstName}");
            Console.WriteLine($"Customer's Firstname is {found.FirstName}");
            Console.WriteLine($"Customer's Phone is {found.Phone}");
            Console.WriteLine($"Customer's Date of birth is {found.DateOfBirth}");
        }
        else
        {
            Console.WriteLine($"Customer with ID {Did} not found!");
        }
    }
    public void toGetAll()
    {
        Console.Clear();
        Console.WriteLine("------ (Customer Service Menu) Get all Customers ------\n");
        List<CustomerModel> allCustomers = customerService.GetAll();
        if (customerService != null)
        {
            foreach (CustomerModel customer in allCustomers)
            {
                Console.WriteLine("______________________________________________________");
                Console.WriteLine($"Customer's ID is {customer.ID}");
                Console.WriteLine($"Customer's Firstname is {customer.FirstName}");
                Console.WriteLine($"Customer's Firstname is {customer.FirstName}");
                Console.WriteLine($"Customer's Phone is {customer.Phone}");
                Console.WriteLine($"Customer's Date of birth is {customer.DateOfBirth}");
                Console.WriteLine("______________________________________________________\n");
            }
        }
        else
        {
            Console.WriteLine("List of Customers is empty.");
        }
    }
}


