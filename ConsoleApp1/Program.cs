using ConsoleApp1;

Product[] Products = new Product[5];

addProduct("kartoshka", "sariq kartoshka", 100);
addProduct("sabzi", "qizil sabzi", 200);
addProduct("piyoz", "kuk piyoz", 350);
addProduct("makaron", "vermishel", 300);
addProduct("birich", "oq birich", 500);

getAllProducts();
Console.WriteLine(Products.Length);

void getAllProducts()
{
    foreach (Product foreachproduct in Products)
    {

        Console.WriteLine("_____________________Product____________________");
        Console.WriteLine($"Product's name is: {foreachproduct.Name}");
        Console.WriteLine($"Product's Description is: {foreachproduct.Description}");
        Console.WriteLine($"Product's Price is: {foreachproduct.Price}");
        Console.WriteLine("________________________________________________");
    }
}

void addProduct(string name, string description, decimal price)
{

    Product product = new Product();
    product.Name = name;
    product.Description = description;
    product.Price = price;


    for (int i = 0; i < Products.Length; i++)
    {
        if (Products[i] == null)
        {
            Products[i] = product;
            break;
        }
    }
}
