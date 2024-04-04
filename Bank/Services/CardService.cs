using Bank.Interfaces;
using Bank.Models;

namespace Bank.Services;

public class CardService : ICardService
{
    List<CardModel> cards;
    public CardService()
    {
        cards = new List<CardModel>();
    }
    public void Create(CardModel card)
    {
        cards.Add(card);
    }
    public bool Delete(int id)
    {
        bool founcCard = false;
        foreach (CardModel card in cards)
        {
            if (card.ID == id)
            {
                cards.Remove(card);
                founcCard = true;
                break;
            }
        }
        return founcCard;
    }
    public List<CardModel> GetAll()
    {
        return cards;
    }
    public List<CardModel> GetAllByCustomerID(int customerId)
    {
        List<CardModel> cardsByCustomerID = new List<CardModel>();
        foreach (CardModel card in cards)
        {
            if (card.ID == customerId)
            {
                cardsByCustomerID.Add(card);
            }
        }
        return cardsByCustomerID;
    }
    public List<CardModel> GetAllByNumber(string cardNumber)
    {
        List<CardModel> cardsByNumber = new List<CardModel>();
        foreach (CardModel card in cards)
        {
            if (card.CardNumber == cardNumber)
            {
                cardsByNumber.Add(card);
            }
        }
        return cardsByNumber;
    }
    public List<CardModel> GetAllByType(CardType cardType)
    {
        List<CardModel> cardsByType = new List<CardModel>();

        foreach (CardModel card in cards)
        {
            if (card.CardType == cardType)
            {
                cardsByType.Add(card);
            }
        }
        return cardsByType;
    }
    public CardModel GetByID(int id)
    {
        CardModel foundCard = null;
        foreach (CardModel card in cards)
        {
            if (card.ID == id)
            {
                foundCard = card;
            }
        }
        return foundCard;
    }
    public bool Update(CardModel card)
    {
        bool foundCard = false;
        foreach (CardModel item in cards)
        {
            if (item.ID == card.ID)
            {
                if (card.ExpireDate != DateTime.MinValue)
                {
                    item.ExpireDate = card.ExpireDate;
                }
                if (card.CardNumber != string.Empty)
                {
                    item.CardNumber = card.CardNumber;
                }
                if (card.CustomerID != 0)
                {
                    item.CustomerID = card.CustomerID;
                }
                if (item.Balance != 0)
                {
                    item.Balance = card.Balance;
                }
                if (item.CardType != CardType.None)
                {
                    item.CardType = card.CardType;
                }
                foundCard = true;
                break;
            }
        }
        return foundCard;
    }
}
