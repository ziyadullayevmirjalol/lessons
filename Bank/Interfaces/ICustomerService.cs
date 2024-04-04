using Bank.Models;

namespace Bank.Interfaces;

public interface ICustomerService
{
    void Create(CustomerModel customer);
    bool Update(CustomerModel Customer);
    bool Delete(int id);
    CustomerModel GetByID(int id);
    List<CustomerModel> GetAll();
}