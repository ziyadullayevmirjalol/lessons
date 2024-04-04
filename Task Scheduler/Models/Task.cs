namespace Task_Scheduler.Models;
public class TaskModel
{
    public int Id { get; set; }
    public int UserID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime DueDate { get; set; }
}
