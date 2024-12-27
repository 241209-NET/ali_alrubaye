using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gallery.API.Model;

public class Role{

    
    public int RoleId {get; set;}
    public required string Name {get;set;}
    [ForeignKey("UserId")]
    public required User User {get;set;}

}