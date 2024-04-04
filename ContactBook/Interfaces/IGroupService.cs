using ContactBook.Models;

namespace ContactBook.Interfaces;

public interface IGroupService
{
    GroupModel Create(GroupModel group);
    GroupModel Update(GroupModel group);
    bool Delete(int id);
    GroupModel GetById(int id);
    List<GroupModel> GetAll();
    (int ContactID, int GroupID) AddContact(ContactModel contact, int toGroupID);
    List<ContactModel> GetContactsByGroupID(int groupID);
}
