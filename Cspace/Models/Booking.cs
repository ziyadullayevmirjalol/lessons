namespace Cspace.Models;

public class Booking
{
    public int Id { get; set; }
    public int UserID { get; set; }
    public int PlaceID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}