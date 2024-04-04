using Cspace.Models;

namespace Cspace.Interfaces;

public interface IFeatureInterface
{
    Feature Create(Feature feature);
    Feature Update(Feature feature);
    bool Delete(Feature feature);
    Feature GetByID(int id);
    List<Feature> GetAll();
}