using Cspace.Models;

namespace Cspace.Interfaces;

public interface IUserService
{
    User Create(User user);
    User Update(User user);
    bool Delete(User user);
    User GetByID(int id);
    List<User> GetAll();
}
