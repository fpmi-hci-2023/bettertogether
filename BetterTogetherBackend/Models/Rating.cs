namespace BetterTogetherBackend.Models;

public class Rating
{
    public int Id { get; set; }
    public User User { get; set; }
    public Media Media { get; set; }
    public short Value { get; set; }
}