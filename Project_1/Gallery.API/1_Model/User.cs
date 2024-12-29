using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gallery.API.Model;

public class User{

    public int UserId {get; set;}
    public required string Name {get;set;}
    public List<Painting> Paintings {get;set;}=[];

    // [InverseProperty("User")]
    public required Role Role {get;set;}
}