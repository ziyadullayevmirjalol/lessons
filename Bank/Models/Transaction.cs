namespace Bank.Models;

public class TransactionModel
{
    public TransactionModel()
    {

    }

    public int ID { get; set; }
    public int EmployeeID { get; set; }
    public int CustomerID { get; set; }
    public int CardID { get; set; }
    public decimal Quantity { get; set; }
    public TransactionType TransactionType { get; set; }
}
