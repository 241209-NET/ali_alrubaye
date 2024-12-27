using Microsoft.AspNetCore.Mvc;

namespace Gallery.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase{

[HttpGet]
public IActionResult ReturnH(){
    return Ok("Helloooooooooooooo");
}
}