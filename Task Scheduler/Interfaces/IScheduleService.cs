using Task_Scheduler.Models;

namespace Task_Scheduler.Interfaces;

public interface IScheduleService
{
    ScheduleModel Create(ScheduleModel user);
    ScheduleModel Update(ScheduleModel user);
    bool Delete(ScheduleModel user);
    List<ScheduleModel> GetAll();
    ScheduleModel Get(int id);
}
