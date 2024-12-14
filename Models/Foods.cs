using System.Reflection;

namespace TasteTheRainbow.Models;

public class Food {
    public int id {get; set;}
    public string name {get; set;}
    public FoodGroup foodGroup {get; set;}
    public string image {get; set;}
}