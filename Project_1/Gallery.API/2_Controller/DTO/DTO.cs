using System.ComponentModel.DataAnnotations;
using Gallery.API.Model;

namespace Gallery.API.DTO;

public class UserDTO{
    public required string User_Role {get;set;}
    public required string User_Name {get;set;}
}

public class PaintingDTO{
    public required string Title_Of_Painting {get;set;}
    public required int Owner_Artist_Id {get;set;}
    public required double Price_Estimate {get;set;}
    
}

public class PaintingUpdateDTO{
    public required int Id_Of_Painting {get;set;}
    public required string New_Title_Of_Painting {get;set;}
    public required double New_Price_Estimate {get;set;}
}

