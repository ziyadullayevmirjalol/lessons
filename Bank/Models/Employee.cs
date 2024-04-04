namespace Bank.Models;

public class EmployeeModel
{
    public EmployeeModel()
    {

    }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Position Position { get; set; }
    public string PassportNumber { get; set; }
}
