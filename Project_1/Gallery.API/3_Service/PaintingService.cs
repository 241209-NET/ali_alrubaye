using Gallery.API.Model;
using Gallery.API.Repository;

namespace Gallery.API.Service;

public class PaintingService : IPaintingService {

    private readonly IPaintingRepository _paintingRespository;
    public PaintingService(IPaintingRepository paintingRepository) => _paintingRespository = paintingRepository;

    
    
    public Painting CreateNewPainting(Painting painting)
    {
        throw new NotImplementedException();
    }

    public Painting DeletePaintingById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Painting> GetAllPaintings()
    {
        throw new NotImplementedException();
    }

    public Painting GetPaintingById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Painting> GetPaintingByName(string name)
    {
        throw new NotImplementedException();
    }

    public Painting UpdatePainting(Painting painting)
    {
        throw new NotImplementedException();
    }
}