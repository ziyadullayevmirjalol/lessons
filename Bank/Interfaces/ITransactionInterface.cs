using Bank.Models;

namespace Bank.Interfaces;

public interface ITransactionInterface
{
    void Create(TransactionModel transaction);
    TransactionModel GetByID(int id);
    List<TransactionModel> GetAllByCardID(int id);
    List<TransactionModel> GetAllByCustomerID(int id);
    List<TransactionModel> GetAllByType(TransactionType transactionType);
}
