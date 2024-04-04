using Bank.Interfaces;
using Bank.Models;

namespace Bank.ConsoleUI.Card;

public class CardUI
{
    ICardService CardService;
    public void toCreate()
    {
        int id = 0;
        int customerId = 0;
        CardType cardType = CardType.None;
        string cardNumber = string.Empty;
        DateTime expireDate = DateTime.MinValue;

        CardModel cardModel = new CardModel();
        cardModel.ID = id;
        cardModel.CustomerID = customerId;
        cardModel.CardType = cardType;
        cardModel.CardNumber = cardNumber;
        cardModel.ExpireDate = expireDate;

        CardService.Create(cardModel);
    }
    public void toUpdate()
    {
        int id = 0;
        int customerId = 0;
        CardType cardType = CardType.None;
        string cardNumber = string.Empty;
        DateTime expireDate = DateTime.MinValue;

        CardModel cardModel = new CardModel();
        cardModel.ID = id;
        cardModel.CustomerID = customerId;
        cardModel.CardType = cardType;
        cardModel.CardNumber = cardNumber;
        cardModel.ExpireDate = expireDate;

        var found = CardService.Update(cardModel);
        if (found == false)
        {
            Console.WriteLine($"Card with ID {id} not found.");
        }
    }
    public void toDelete()
    {
        int id = 0;

        var found = CardService.Delete(id);
        if (found == false)
        {
            Console.WriteLine($"Card with ID {id} not found.");
        }
    }
    public void toGetAll()
    {
        List<CardModel> list = CardService.GetAll();
        foreach (CardModel model in list)
        {
            Console.WriteLine("______________________________________________________");
            Console.WriteLine($"Card's ID is {model.ID}");
            Console.WriteLine($"Card's CustomerID is {model.CustomerID}");
            Console.WriteLine($"Card's Card Number is {model.CardNumber}");
            Console.WriteLine($"Card's ExpireDate is {model.ExpireDate}");
            Console.WriteLine($"Card's Type is {model.CardType}");
            Console.WriteLine($"Card's Balance is {model.Balance}");
            Console.WriteLine("______________________________________________________\n");
        }
        if (list == null)
        {
            Console.WriteLine("List of Cards is empty.");
        }
    }
    public void toGetByID()
    {
        int id = 0;

        var found = CardService.GetByID(id);
        if (found == null)
        {
            Console.WriteLine($"Card with ID {id} not found.");
        }
    }
    public void toGetAllByCustomerID()
    {

    }
    public void toGetAllByNumber()
    {

    }
    public void toGetAllByCardType()
    {

    }
}
