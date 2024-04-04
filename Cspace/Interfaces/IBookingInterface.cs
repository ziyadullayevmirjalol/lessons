using Cspace.Models;

namespace Cspace.Interfaces;

public interface IBookingInterface
{
    Booking Create(Booking booking);
    Booking Update(Booking booking);
    bool Delete(Booking booking);
    Booking GetByID(int id);
    (string placenumber, DateTime startTime, DateTime endTime) GetByUserId(int userid);
    List<Booking> GetAll();
}