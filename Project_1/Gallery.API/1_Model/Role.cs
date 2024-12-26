namespace Gallery.API.Model;

public class Role{

    public int Id {get; set;}
    public required string Name {get;set;}

    public List<Artist> Artists {get;set;}=[];

}