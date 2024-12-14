namespace TasteTheRainbow.Models;

public class FoodGroup {
    public int id {get; set;}
    public string group {get; set;}
    public List<Food> foods {get; set;}
}