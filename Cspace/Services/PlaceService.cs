using Cspace.Interfaces;
using Cspace.Models;

namespace Cspace.Services;

public class PlaceService : IPlaceService
{
    private List<Place> _places;
    public PlaceService()
    {
        _places = new List<Place>();
    }


    public Place Create(Place place)
    {
        place.Id = _places.LastOrDefault().Id + 1;
        _places.Add(place);
        return place;
    }

    public bool Delete(Place user)
    {
        bool found = false;
        foreach (var item in _places)
        {
            if (item.Id == user.Id)
            {
                found = true;
                _places.Remove(item);
                break;
            }
        }

        return found;
    }

    public List<Place> GetAll()
    {
        return _places;
    }

    public List<Place> GetAvailablePlaces()
    {
        List<Place> result = new List<Place>();
        foreach (var place in _places)
        {
            if (place.IsAvailable == true)
            {
                result.Add(place);
            }
        }
        return result;
    }

    public Place GetByID(int id)
    {
        Place foundPlace = null;
        foreach (var item in _places)
        {
            if (item.Id == id)
            {
                foundPlace = item;
                break;
            }
        }
        if (foundPlace == null)
        {
            throw new Exception("This Place is not found");
        }
        return foundPlace;
    }

    public Place Update(Place place)
    {
        Place updatedPlace = null;
        foreach (var item in _places)
        {
            if (item.Id == place.Id)
            {
                item.Floor = place.Floor;
                item.Room = place.Room;
                item.Number = place.Number;
                item.Price = place.Price;
                item.IsAvailable = place.IsAvailable;

                updatedPlace = item;
                break;
            }
        }
        if (updatedPlace == null)
        {
            throw new Exception("This Place is not found");
        }
        return updatedPlace;
    }
}
