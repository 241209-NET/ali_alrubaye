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
    return Ok(_paintingService.GetPaintingById(id));
}

[HttpDelete("{id}")]
public IActionResult DeletePaintingById(int id){
    return Ok(_paintingService.DeletePaintingById(id));
}

[HttpGet("byname/{name}")]
public IActionResult RetrievePaintingByName(string name){
    return Ok(_paintingService.GetPaintingByName(name));
}


[HttpPost]
public IActionResult AddNewPainting(PaintingDTO dto){
    return Ok(_paintingService.CreateNewPainting(dto));
}

[HttpPut]
public IActionResult UpdateExistingPainting(PaintingUpdateDTO dto){    
    return Ok(_paintingService.UpdatePainting(dto));
}




}