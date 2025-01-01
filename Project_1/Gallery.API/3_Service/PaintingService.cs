using Gallery.API.DTO;
using Gallery.API.Model;
using Gallery.API.Repository;

namespace Gallery.API.Service;

public class PaintingService(IPaintingRepository paintingRepository, IUserRepository userRepository) : IPaintingService {

    private readonly IPaintingRepository _paintingRespository = paintingRepository;
    private readonly IUserRepository _userRepository = userRepository;



    public Painting CreateNewPainting(PaintingDTO dto)
    {
        
        return _paintingRespository.CreateNewPainting(dto);
    }

   public Painting DeletePaintingById(int id)
    {
        return _paintingRespository.DeletePaintingById(id);
    }

    public IEnumerable<Painting> GetAllPaintings()
    {
        return _paintingRespository.GetAllPaintings();
    }

    public Painting GetPaintingById(int id)
    {
        return _paintingRespository.GetPaintingById(id);
    }

    public IEnumerable<Painting> GetPaintingByName(string name)
    {
        return _paintingRespository.GetPaintingByName(name);
    }

    public Painting UpdatePainting(PaintingUpdateDTO dto)
    {
        return _paintingRespository.UpdatePainting(dto);
    }




}