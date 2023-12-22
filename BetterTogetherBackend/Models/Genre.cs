﻿namespace BetterTogetherBackend.Models;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Media> Medias { get; set; }
}