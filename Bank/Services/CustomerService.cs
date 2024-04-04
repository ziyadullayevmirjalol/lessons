using Bank.Interfaces;
using Bank.Models;

namespace Bank.Services;

public class CustomerService : ICustomerService
{
    // list of Customers
    List<CustomerModel> customerList;
    public CustomerService()
    {
        customerList = new List<CustomerModel>();
    }

    // service
    public void Create(CustomerModel customer)
    {
        customer.ID = customerList.Last().ID + 1;
        customerList.Add(customer);
    }
    public bool Delete(int id)
    {
        bool foundCustomer = false;
        foreach (CustomerModel item in customerList)
        {
            if (item.ID == id)
            {
                customerList.Remove(item);
                foundCustomer = true;
                break;
            }
        }
        return foundCustomer;
    }
    public bool Update(CustomerModel customer)
    {
        bool foundCustomer = false;
        foreach (CustomerModel item in customerList)
        {
            if (item.ID == customer.ID)
            {
                if (customer.FirstName != string.Empty)
                {
                    item.FirstName = customer.FirstName;
                }
                if (customer.LastName != string.Empty)
                {
                    item.LastName = customer.LastName;
                }
                if (customer.DateOfBirth != DateTime.MinValue)
                {
                    item.DateOfBirth = customer.DateOfBirth;
                }
                if (customer.Phone != string.Empty)
                {
                    item.Phone = customer.Phone;
                }
                foundCustomer = true;
                break;
            }
        }
        return foundCustomer;
    }
    public List<CustomerModel> GetAll()
    {
        return customerList;
    }
    public CustomerModel GetByID(int id)
    {
        CustomerModel Found = null;
        foreach (CustomerModel item in customerList)
        {
            if (item.ID == id)
            {
                Found = item;
                break;
            }
        }
        return Found;
    }
}
