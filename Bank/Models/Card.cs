namespace Bank.Models;

public class CardModel
{

    public CardModel()
    {

    }
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public CardType CardType { get; set; }
    public string CardNumber { get; set; }
    public DateTime ExpireDate { get; set; }
    public decimal Balance { get; set; }
}
