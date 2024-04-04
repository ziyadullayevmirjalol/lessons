using ContactBook.Models;

namespace ContactBook.Interfaces;

public interface IContactService
{
    ContactModel Create(ContactModel contact);
    ContactModel Update(ContactModel contact);
    bool Delete(int id);
    ContactModel GetByID(int id);
    List<ContactModel> GetAll();
}
