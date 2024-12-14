namespace TasteTheRainbow.Models;

public class Child {
    public int Id { get; set; }
    public required string Nickname { get; set; }
    public DateOnly BirthYear { get; set; }
    public string? Photo {get; set;}
    public UserProfile UserProfile {get; set;}
}