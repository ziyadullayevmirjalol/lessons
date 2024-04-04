namespace ContactBook.Models;

public class GroupModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<ContactModel> Contacts { get; set; }
}
