// See https://aka.ms/new-console-template for more information
using Factory_CRUD.Factory;
using Factory_CRUD.FactoryServices;

Console.WriteLine("Hello, World!");

List<Factory> list = new List<Factory>();

IFactory factory = new Factory();

bool loop = true;

while (loop)
{
    Console.WriteLine("enter 1 for get all products");
    Console.WriteLine("enter 2 for create product");
    Console.WriteLine("enter 3 for update product");
    Console.WriteLine("enter 4 for delete product");

    string choice = string.Empty;
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("All products\n");
            factory.GetAllProduct();

            break;
        case "2":
            Console.WriteLine("Create Product");
            Console.WriteLine("What product is it?:");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter details about this product:");
            string pdetails = Console.ReadLine();

            factory.AddProduct(pname, pdetails);
            break;
        case "3":
            Console.WriteLine("Update Product");
            Console.WriteLine("Enter Product's ID:");
            int updatePid = int.Parse(Console.ReadLine());
            Console.WriteLine("What product is it?:");
            string updatePname = Console.ReadLine();
            Console.WriteLine("Enter details about this product:");
            string updatePdetails = Console.ReadLine();

            factory.UpdateProduct(updatePid, updatePname, updatePdetails);
            break;
        case "4":
            Console.WriteLine("Delete Product");
            Console.WriteLine("Enter Product's ID");
            int deletePid = int.Parse(Console.ReadLine());

            factory.DeleteProduct(deletePid);
            break;
        case "5":
            Console.WriteLine("exit");
            loop = false;
            break;
    }
}




