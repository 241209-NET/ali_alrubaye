using Gallery.API.DTO;
using Gallery.API.Model;
using Gallery.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gallery.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase{

private readonly IUserService _userService;
public UserController(IUserService userService) => _userService = userService;

[HttpGet]
public IActionResult GetAllUsers(){
    var userList = _userService.GetAllUsers();
    return Ok(userList);
}


[HttpPost]
public IActionResult CreateNewUser(UserDTO dto){

    try
    {
        User user = new User{Role=dto.User_Role, Name=dto.User_Name, Paintings=[]};
        return Ok(_userService.CreateNewUser(user));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);        
    }    

}

[HttpGet("{id}")]
public IActionResult RetrieveUserById(int id){

    try
    {
        return Ok(_userService.GetUserById(id));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }
    
}

[HttpDelete("{id}")]
public IActionResult DeleteTheUserById(int id){

    try
    {
        return Ok(_userService.DeleteUserById(id));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }
    
    
}



}