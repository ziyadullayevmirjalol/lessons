namespace Bank.Models;

public class CustomerModel
{
    public CustomerModel()
    {

    }

    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
}
