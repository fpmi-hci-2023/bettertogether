namespace BetterTogetherBackend.Models;

public class Media
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<Genre> Genres { get; set; } 
    public virtual ICollection<User> FavouritesBy { get; set; }
    public virtual ICollection<User> PlannedBy { get; set; }
    public virtual ICollection<Watched> Watched { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
}