using Microsoft.AspNetCore.SignalR;

namespace TasteTheRainbow.Models;

public class MealLog {
    public int id {get; set;}
    public enum Meal {
        Breakfast = 1,
        Lunch = 2,
        Dinner = 3
    }
    public DateTime time {get; set;}
    public string mood {get; set;}
    public List<FoodLog> foodLogs {get; set;}
    public string entry {get; set;} //might be better datatype for long form
    public Child child {get; set;}
}