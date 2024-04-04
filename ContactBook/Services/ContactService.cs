using ContactBook.Interfaces;
using ContactBook.Models;

namespace ContactBook.Services;

internal class ContactService : IContactService
{

    private List<ContactModel> contacts;
    private GroupService groupService;

    public ContactService(GroupService groupService)
    {
        this.groupService = groupService;
        this.contacts = new List<ContactModel>();
    }

    public ContactModel Create(ContactModel contact)
    {
        contact.ID = contacts.Count + 1;
        contacts.Add(contact);

        return contact;
    }

    public bool Delete(int id)
    {
        bool found = false;
        foreach (ContactModel contactModel in contacts)
        {
            if (contactModel.ID == id)
            {
                found = true;
                contacts.Remove(contactModel);
                break;
            }
        }
        return found;
    }
    public List<ContactModel> GetAll()
    {
        if (contacts.Count == 0)
        {
            throw new Exception("Contact list is empty");
        }
        return contacts;
    }

    public ContactModel GetByID(int id)
    {
        ContactModel found = null;
        foreach (ContactModel contactModel in contacts)
        {
            if (contactModel.ID == id)
            {
                found = contactModel;
                break;
            }
        }
        return found;
    }

    public ContactModel Update(ContactModel contact)
    {
        ContactModel found = null;
        foreach (ContactModel contactModel in contacts)
        {
            if (contact.ID == contactModel.ID)
            {
                contactModel.Name = contact.Name;
                contactModel.Email = contact.Email;
                contactModel.Address = contact.Address;
                contactModel.Number = contact.Number;
                found = contactModel;
                break;
            }
        }
        return found;
    }
}
