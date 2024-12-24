namespace Gallery.API.Model;

public class Painting{

    public int Id {get; set;}
    public required string Name {get;set;}

    public double Price {get;set;}

    public required Artist Artist{get;set;}

}