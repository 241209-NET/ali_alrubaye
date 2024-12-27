using System.ComponentModel.DataAnnotations;

namespace Gallery.API.Model;

public class User{

    public int UserId {get; set;}
    public required string Name {get;set;}
    public List<Painting> Paintings {get;set;}=[];
    public required Role Role {get;set;}
}