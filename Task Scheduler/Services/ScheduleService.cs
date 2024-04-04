using Task_Scheduler.Interfaces;
using Task_Scheduler.Models;

namespace Task_Scheduler.Services;

public class ScheduleService : IScheduleService
{
    List<ScheduleModel> _users;

    public ScheduleService()
    {
        _users = new List<ScheduleModel>();
    }
    public ScheduleModel Create(ScheduleModel user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
        return user;
    }

    public bool Delete(ScheduleModel user)
    {
        bool found = false;
        foreach (var item in _users)
        {
            if (user.Id == item.Id)
            {
                _users.Remove(item);
                found = true;
            }
        }
        return found;
    }

    public ScheduleModel Get(int id)
    {
        ScheduleModel user = null;
        foreach (var item in _users)
        {
            if (item.Id == id)
            {
                user = item;
                break;
            }
        }
        if (user == null)
        {
            throw new Exception("This user is not found");
        }
        return user;
    }

    public List<ScheduleModel> GetAll()
    {
        return _users;
    }

    public ScheduleModel Update(ScheduleModel user)
    {
        ScheduleModel found = null;
        foreach (var item in _users)
        {
            if (user.Id == item.Id)
            {
                item.Firstname = user.Firstname;
                item.Lastname = user.Lastname;
                found = item;
            }
        }
        return found;
    }
}
