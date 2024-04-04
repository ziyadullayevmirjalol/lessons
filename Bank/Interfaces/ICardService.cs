using Bank.Models;

namespace Bank.Interfaces;

public interface ICardService
{
    void Create(CardModel card);
    bool Update(CardModel card);
    bool Delete(int id);
    List<CardModel> GetAll();
    CardModel GetByID(int id);
    List<CardModel> GetAllByCustomerID(int customerId);
    List<CardModel> GetAllByNumber(string cardNumber);
    List<CardModel> GetAllByType(CardType cardType);
}
