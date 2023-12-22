namespace BetterTogetherBackend.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public virtual ICollection<User> Friends { get; set; }
    public virtual ICollection<Media> Favourites { get; set; }
    public virtual ICollection<Media> Planned { get; set; }
    public virtual ICollection<Watched> Watched { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
}