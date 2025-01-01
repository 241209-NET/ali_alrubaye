using System.ComponentModel.DataAnnotations;

namespace Gallery.API.Model;

public class Painting{

    public int PaintingId {get; set;}
    public required string Name {get;set;}
    public double Price {get;set;}
    public required User User{get;set;}

}