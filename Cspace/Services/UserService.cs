using Cspace.Interfaces;
using Cspace.Models;

namespace Cspace.Services;

public class UserService : IUserService
{
    private List<User> _users;
    public UserService()
    {
        _users = new List<User>();
    }


    public User Create(User user)
    {
        foreach (var item in _users)
        {
            if (item.Phone == user.Phone)
            {
                throw new Exception("This User is already exists");
            }
        }
        user.Id = _users.Count + 1;
        _users.Add(user);
        return user;
    }

    public bool Delete(User user)
    {
        bool found = false;
        foreach (var item in _users)
        {
            if (item.Id == user.Id)
            {
                found = true;
                _users.Remove(item);
                break;
            }
        }
        return found;
    }

    public List<User> GetAll()
    {
        return _users;
    }

    public User GetByID(int id)
    {
        User foundUser = null;
        foreach (var item in _users)
        {
            if (item.Id == id)
            {
                foundUser = item;
                break;
            }
        }
        if (foundUser == null)
        {
            throw new Exception("This User is not found");
        }
        return foundUser;
    }

    public User Update(User user)
    {
        User updatedUser = null;
        foreach (var item in _users)
        {
            if (item.Id == user.Id)
            {
                item.FirstName = user.FirstName;
                item.LastName = user.LastName;
                item.Phone = user.Phone;
                item.Email = user.Email;

                updatedUser = item;
                break;
            }
        }
        if (updatedUser == null)
        {
            throw new Exception("This User is not found");
        }
        return updatedUser;
    }
}
