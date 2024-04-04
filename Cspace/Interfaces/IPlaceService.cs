using Cspace.Models;

namespace Cspace.Interfaces;

public interface IPlaceService
{
    Place Create(Place place);
    Place Update(Place place);
    bool Delete(Place place);
    Place GetByID(int id);
    List<Place> GetAll();
    List<Place> GetAvailablePlaces();
}
