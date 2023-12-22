using BetterTogetherBackend.Enums;

namespace BetterTogetherBackend.Models;

public class Watched
{
    public int Id { get; set; }
    public User User { get; set; }
    public Media Media { get; set; }
    public string Timecode { get; set; }
    public WatchedStatus Status { get; set; }
}