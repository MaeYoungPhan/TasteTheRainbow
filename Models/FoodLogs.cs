using System.Drawing;

namespace TasteTheRainbow.Models;

public class FoodLog {
    public int id {get; set;}
    public Food food {get; set;}
    public Interaction interaction {get; set;}
    public enum BiteSize {
        Ant,
        Dog,
        Alligator,
    }
    public Reaction reaction {get; set;}
    public string notes {get; set;} //might be better datatype for long form notes
    public List<Color> colors {get; set;}
    public Child child {get; set;}

}