using Product_CRUD;

List<Product> products = new List<Product>();

bool loop = true;


while (loop == true)
{
    Console.WriteLine("--------------------------------");
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Product Inventory program.");
    Console.ResetColor();
    Console.WriteLine("--------------------------------\n");
    Console.WriteLine("1. Get list of all products.");
    Console.WriteLine("2. Create new Product.");
    Console.WriteLine("3. Update product.");
    Console.WriteLine("4. Delete product.");
    Console.WriteLine("5. Search products.\n");
    Console.WriteLine("6. Exit program.\n");
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter your choice: ");
    Console.ResetColor();

    string choice = (Console.ReadLine());
    Console.Clear();
    var UID = 0;

    switch (choice)
    {
        case "1":
            GetAllProducts();

            break;
        case "2":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Create Product----|\n");
            Console.ResetColor();
        createName:
            Console.Write("Enter product's Name: ");
            string createname = Console.ReadLine();
            if (createname == "")
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto createName;
            }
        createDescription:
            Console.Write("Enter product's Description: ");
            string createdescription = Console.ReadLine();
            if (createdescription == "")
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto createDescription;
            }
            Console.WriteLine("-------------------------\n");

            CreateProduct(createname, createdescription);

            break;
        case "3":

            string updatename = string.Empty;
            string updatedescription = string.Empty;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Update Product----|\n");
            Console.ResetColor();
        updateId:
            Console.Write("Enter product's ID: ");
            string[] updatevalues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9,", "0" };
            var getUpdate = Console.ReadLine();
            if (getUpdate != "" && (updatevalues.Any(getUpdate.Contains)))
            {

                UID = int.Parse(getUpdate);
            }
            else
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto updateId;
            }
        updateName:
            Console.Write("Enter product's Name: ");
            updatename = Console.ReadLine();
            if (updatename == "")
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto updateName;
            }
        updateDescription:
            Console.Write("Enter product's Description: ");
            updatedescription = Console.ReadLine();
            if (updatedescription == "")
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto updateDescription;
            }

            UpdateProduct(UID, updatename, updatedescription);

            Console.WriteLine("-------------------------\n");

            break;

        case "4":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Delete Product----|\n");
            Console.ResetColor();
        deleteId:
            Console.Write("Enter product's ID: ");
            string[] deletevalues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9,", "0" };
            var getDelete = Console.ReadLine();
            if (getDelete != "" && (deletevalues.Any(getDelete.Contains)))
            {
                int deleteid = int.Parse(getDelete);
                DeleteProduct(deleteid);
            }
            else
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto deleteId;
            }

            break;
        case "5":
            string searchname = string.Empty;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Search Product----|\n");
            Console.ResetColor();

        searchName:
            Console.Write("Enter product's Name: ");
            searchname = Console.ReadLine();
            if (searchname == "")
            {
                Console.WriteLine("Invalid Input.Press any key to re-enter");
                goto updateName;
            }
            else
            {
                SearchProduct(searchname);
            }

            Console.WriteLine("-------------------------\n");

            break;
        case "6":
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Exit program...\n");
            Console.ResetColor();
            loop = false;

            break;
        default:

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid Input.Press any key to re-enter");
            Console.ResetColor();
            Console.ReadLine();

            continue;
    }
}


void GetAllProducts()
{
    if (products.Count == 0)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"-----------------------------GetAllProducts------------------------------\n");
        Console.ResetColor();
        Console.WriteLine("No product's here, you should create them\n");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--------------------------------------------------------------------------\n");
        Console.ResetColor();
        return;
    }
    else
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"--------------------------GetAllProducts---------------------------------\n");
        Console.ResetColor();
        foreach (var product in products)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"----------------Product {product.Id}----------------\n");
            Console.ResetColor();
            Console.WriteLine($"Product's ID: {product.Id}");
            Console.WriteLine($"Product's Name: {product.Name}");
            Console.WriteLine($"Product's Description: {product.Description}\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------------------------------------\n");
            Console.ResetColor();

        }
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--------------------------------------------------------------------------\n");
        Console.ResetColor();
    }
}
void SearchProduct(string name)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"--------------------------Search Products---------------------------------\n");
    Console.ResetColor();
    foreach (Product product in products)
    {
        if (product.Name == name)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"----------------Match Product {product.Id}----------------\n");
            Console.ResetColor();
            Console.WriteLine($"Product's ID: {product.Id}");
            Console.WriteLine($"Product's Name: {product.Name}");
            Console.WriteLine($"Product's Description: {product.Description}\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------------------------------------\n");
            Console.ResetColor();
        }
    }
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("--------------------------------------------------------------------------\n");
    Console.ResetColor();
}
void CreateProduct(string name, string description)
{
    Product product = new Product();
    product.Id = products.Count + 1;
    product.Name = name;
    product.Description = description;

    products.Add(product);

    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("----------------Created Product----------------\n");
    Console.ResetColor();
    Console.WriteLine($"Product's ID: {product.Id}");
    Console.WriteLine($"Product's Name: {product.Name}");
    Console.WriteLine($"Product's Description: {product.Description}\n");
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("-----------------------------------------------\n");
    Console.ResetColor();
}
void UpdateProduct(int id, string name, string description)
{
    bool found = false;
    foreach (var product in products)
    {
        if (product.Id == id)
        {
            if (name != "")
            {
                product.Name = name;
            }
            if (description != "")
            {
                product.Description = description;
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("------------------Update Product-----------------\n");
            Console.ResetColor();
            Console.WriteLine($"Product with ID {product.Id} updated\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------------------------------------\n");
            Console.ResetColor();
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("------------------Update Product-----------------\n");
        Console.ResetColor();
        Console.WriteLine("no product with such an ID\n");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-------------------------------------------------\n");
        Console.ResetColor();
        return;
    }
}
void DeleteProduct(int id)
{
    bool found = false;
    foreach (var product in products)
    {
        if (product.Id == id)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("------------------Delete Product-----------------\n");
            Console.ResetColor();
            Console.WriteLine($"Product with ID {product.Id} removed\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------------------------------------\n");
            Console.ResetColor();

            products.Remove(product);
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("------------------Delete Product-----------------\n");
        Console.ResetColor();
        Console.WriteLine("no product with such an ID\n");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-------------------------------------------------\n");
        Console.ResetColor();
        return;
    }
}
