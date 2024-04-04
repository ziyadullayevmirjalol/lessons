using Cspace.Interfaces;
using Cspace.Models;

namespace Cspace.Services;

public class BookingService : IBookingInterface
{
    private List<Booking> _bookings;
    private readonly PlaceService _placeService;
    private readonly UserService _userService;
    public BookingService(PlaceService placeService, UserService userService)
    {
        _bookings = new List<Booking>();
        _placeService = placeService;
        _userService = userService;
    }

    public Booking Create(Booking booking)
    {
        _userService.GetAll();
        Place place = _placeService.GetByID(booking.PlaceID);
        if (place.IsAvailable != true)
        {
            throw new Exception("This place is already taken!");
        }

        booking.Id = _bookings.LastOrDefault().Id + 1;
        _bookings.Add(booking);
        return booking;
    }

    public bool Delete(Booking booking)
    {
        bool found = false;
        foreach (var item in _bookings)
        {
            if (item.Id == booking.Id)
            {
                found = true;
                _bookings.Remove(item);
                break;
            }
        }

        return found;
    }

    public List<Booking> GetAll()
    {
        return _bookings;
    }

    public Booking GetByID(int id)
    {
        Booking foundBooking = null;
        foreach (var item in _bookings)
        {
            if (item.Id == id)
            {
                foundBooking = item;
                break;
            }
        }
        if (foundBooking == null)
        {
            throw new Exception("This Booking is not found");
        }
        return foundBooking;
    }
    public Booking Update(Booking booking)
    {
        Booking updatedBooking = null;
        foreach (var item in _bookings)
        {
            if (item.Id == booking.Id)
            {
                item.UserID = booking.UserID;
                item.PlaceID = booking.PlaceID;
                item.StartTime = booking.StartTime;
                item.EndTime = booking.EndTime;

                updatedBooking = item;
                break;
            }
        }
        if (updatedBooking == null)
        {
            throw new Exception("This booking is not found");
        }

        return updatedBooking;
    }

    (string placenumber, DateTime startTime, DateTime endTime) IBookingInterface.GetByUserId(int userid)
    {

        Booking found = null;
        User userFound = _userService.GetByID(userid);

        foreach (var item in _bookings)
        {
            if (item.UserID == userid)
            {
                found = item;
                break;
            }
        }
        if (found == null)
        {
            throw new Exception("This Booking is not found");
        }

        Place place = _placeService.GetByID(found.PlaceID);

        return (placenumber: place.Number, startTime: found.StartTime, endTime: found.EndTime);
    }
}
