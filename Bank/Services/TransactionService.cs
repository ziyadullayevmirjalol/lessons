using Bank.Interfaces;
using Bank.Models;

namespace Bank.Services;

public class TransactionService : ITransactionInterface
{
    List<TransactionModel> transactions;
    public TransactionService()
    {
        transactions = new List<TransactionModel>();
    }
    public void Create(TransactionModel trasaction)
    {
        transactions.Add(trasaction);
    }
    public List<TransactionModel> GetAllByCardID(int id)
    {
        List<TransactionModel> transactionsByID = new List<TransactionModel>();
        foreach (TransactionModel transaction in transactions)
        {
            if (transaction.CardID == id)
            {
                transactionsByID.Add(transaction);
            }
        }
        return transactionsByID;
    }
    public List<TransactionModel> GetAllByCustomerID(int id)
    {
        List<TransactionModel> transactionsByCustomerID = new List<TransactionModel>();
        foreach (TransactionModel transaction in transactions)
        {
            if (transaction.CustomerID == id)
            {
                transactionsByCustomerID.Add(transaction);
            }
        }
        return transactionsByCustomerID;
    }
    public List<TransactionModel> GetAllByType(TransactionType transactionType)
    {
        List<TransactionModel> transactionsByType = new List<TransactionModel>();
        foreach (TransactionModel transaction in transactions)
        {
            if (transaction.TransactionType == transactionType)
            {
                transactionsByType.Add(transaction);
            }
        }
        return transactionsByType;
    }
    public TransactionModel GetByID(int id)
    {
        TransactionModel Found = null;
        foreach (TransactionModel transaction in transactions)
        {
            if (transaction.ID == id)
            {
                Found = transaction;
            }
        }
        return Found;
    }
}
