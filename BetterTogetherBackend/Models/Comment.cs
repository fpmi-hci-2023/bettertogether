namespace BetterTogetherBackend.Models;

public class Comment
{
    public int Id { get; set; }
    public User User { get; set; }
    public Media Media { get; set; }
    public string Text { get; set; }
    public DateTime PostingTime { get; set; }
}