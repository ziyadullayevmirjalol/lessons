using Cspace.Interfaces;
using Cspace.Models;

namespace Cspace.Services;

public class FeatureService : IFeatureInterface
{
    private List<Feature> _features;
    public FeatureService()
    {
        _features = new List<Feature>();
    }


    public Feature Create(Feature feature)
    {
        feature.Id = _features.LastOrDefault().Id + 1;
        _features.Add(feature);
        return feature;
    }

    public bool Delete(Feature feature)
    {
        bool found = false;
        foreach (var item in _features)
        {
            if (item.Id == feature.Id)
            {
                found = true;
                _features.Remove(item);
                break;
            }
        }
        return found;
    }

    public List<Feature> GetAll()
    {
        return _features;
    }

    public Feature GetByID(int id)
    {
        Feature foundFeature = null;
        foreach (var item in _features)
        {
            if (item.Id == id)
            {
                foundFeature = item;
                break;
            }
        }
        if (foundFeature == null)
        {
            throw new Exception("This Feature is not found");
        }
        return foundFeature;
    }

    public Feature Update(Feature feature)
    {
        Feature updatedFeature = null;
        foreach (var item in _features)
        {
            if (item.Id == feature.Id)
            {
                item.Name = feature.Name;

                updatedFeature = item;
                break;
            }
        }
        if (updatedFeature == null)
        {
            throw new Exception("This Feature is not found");
        }
        return updatedFeature;
    }
}
