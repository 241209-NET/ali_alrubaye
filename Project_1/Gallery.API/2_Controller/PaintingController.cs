using Gallery.API.DTO;
using Gallery.API.Model;
using Gallery.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gallery.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PaintingController : ControllerBase{

    private readonly IPaintingService _paintingService;
    public PaintingController(IPaintingService paintingService) => _paintingService = paintingService;

[HttpGet]
public IActionResult RetrieveAllPaintings(){
    return Ok(_paintingService.GetAllPaintings());
}

[HttpGet("{id}")]
public IActionResult RetrievePaintingById(int id){
    try
    {
        return Ok(_paintingService.GetPaintingById(id));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }
}

[HttpDelete("{id}")]
public IActionResult DeletePaintingById(int id){
    try
    {
        return Ok(_paintingService.DeletePaintingById(id));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }
    
}

[HttpGet("byname/{name}")]
public IActionResult RetrievePaintingByName(string name){
    return Ok(_paintingService.GetPaintingByName(name));
}


[HttpPost]
public IActionResult AddNewPainting(PaintingDTO dto){
    try
    {
        return Ok(_paintingService.CreateNewPainting(dto));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }
    
}

[HttpPut]
public IActionResult UpdateExistingPainting(PaintingUpdateDTO dto){ 
    try
    {
        return Ok(_paintingService.UpdatePainting(dto));
    }
    catch (Exception e)
    {
        return Conflict(e.Message);
    }   
    
}




}