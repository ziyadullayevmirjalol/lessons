namespace Cspace.Models;
public class Place
{
    public int Id { get; set; }
    public string Number { get; set; }
    public int Floor { get; set; }
    public string Room { get; set; }
    public bool IsAvailable { get; set; } = true;
    public decimal Price { get; set; }
    public List<Feature> Features { get; set; }
}
