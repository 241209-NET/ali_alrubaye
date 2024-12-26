namespace Gallery.API.Model;

public class Artist{

    public int Id {get; set;}
    public required string Name {get;set;}

    public List<Painting> Paintings {get;set;}=[];

    public List<Role> Roles {get;set;}=[];

}