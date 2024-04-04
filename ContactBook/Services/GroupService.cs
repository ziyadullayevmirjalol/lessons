using ContactBook.Interfaces;
using ContactBook.Models;

namespace ContactBook.Services;

internal class GroupService : IGroupService
{
    private List<GroupModel> groups;
    private ContactService contactService;
    public GroupService(ContactService contactService)
    {
        this.contactService = contactService;
        groups = new List<GroupModel>();
    }

    public (int ContactID, int GroupID) AddContact(ContactModel contact, int toGroupID)
    {
        ContactModel foundContact = contactService.GetByID(contact.ID);
        GroupModel foundGroup = GetById(toGroupID);

        if (foundContact != null)
        {
            if (foundGroup != null)
            {
                foundGroup.Contacts.Add(contact);
            }
            else
            {
                throw new Exception("Group not found");
            }
        }
        else
        {
            throw new Exception("Contact not found");
        }
        return (foundContact.ID, foundGroup.ID);
    }

    public GroupModel Create(GroupModel group)
    {
        group.ID = groups.Count + 1;
        groups.Add(group);
        return group;
    }
    public bool Delete(int ID)
    {
        bool found = false;
        foreach (GroupModel group in groups)
        {
            if (group.ID == ID)
            {
                found = true;
                groups.Remove(group);
                break;
            }
        }
        return found;
    }
    public List<GroupModel> GetAll()
    {
        if (groups.Count == 0)
        {
            throw new Exception("Group list is empty.");
        }
        return groups;
    }
    public GroupModel GetById(int id)
    {
        GroupModel found = null;
        foreach (GroupModel group in groups)
        {
            if (group.ID == id)
            {
                found = group;
                break;
            }
        }
        return found;
    }
    public List<ContactModel> GetContactsByGroupID(int groupID)
    {
        List<ContactModel> found = null;

        foreach (GroupModel group in groups)
        {
            if (group.ID == groupID)
            {
                found = group.Contacts;
                break;
            }
        }
        if (found == null)
        {
            throw new Exception("Group not found");
        }
        return found;
    }
    public GroupModel Update(GroupModel group)
    {
        GroupModel found = null;
        foreach (GroupModel contact in groups)
        {
            if (contact.ID == group.ID)
            {
                contact.Name = group.Name;
                found = contact;
                break;
            }
        }
        if (found == null)
        {
            throw new Exception("Group is not found");
        }
        return found;
    }
}
