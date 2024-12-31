using System.ComponentModel.DataAnnotations;
using Gallery.API.Model;

namespace Gallery.API.DTO;

public class UserDTO{
    public required string Role {get;set;}
    public required string Name {get;set;}
}

