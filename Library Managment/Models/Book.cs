namespace Library_Managment.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string PublicationYear { get; set; }
    public bool isBorrowed { get; set; } = false;
    public int borrowedMemberID { get; set; }
    public bool isAvailable { get; set; } = true;
}
