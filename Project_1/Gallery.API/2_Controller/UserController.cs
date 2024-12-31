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

// [HttpPost]
// public IActionResult CreateNewUser(User user){
//     return Ok(_userService.CreateNewUser(user));
// }
[HttpPost]
public IActionResult CreateNewUser(UserDTO dto){
    User user = new User{Role=dto.Role, Name=dto.Name, Paintings=[]};
    return Ok(_userService.CreateNewUser(user));
}

[HttpGet("{id}")]
public IActionResult RetrieveUserById(int id){
    return Ok(_userService.GetUserById(id));
}

[HttpDelete("{id}")]
public IActionResult DeleteTheUserById(int id){
    return Ok(_userService.DeleteUserById(id));
}



}