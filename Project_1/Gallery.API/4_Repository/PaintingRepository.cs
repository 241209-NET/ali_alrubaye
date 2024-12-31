using Gallery.API.Data;
using Gallery.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Gallery.API.Repository;

public class PaintingRepository : IPaintingRepository{
    
    private readonly GalleryContext _galleryContext;

    public PaintingRepository(GalleryContext galleryContext) => _galleryContext = galleryContext;

    public Painting CreateNewPainting(Painting painting)
    {
        _galleryContext.Painting.Add(painting);
        _galleryContext.SaveChanges();
        return painting;
    }

    public Painting DeletePaintingById(int id)
    {
        Painting? p = _galleryContext.Painting.Find(id);
        _galleryContext.Painting.Remove(p);
        _galleryContext.SaveChanges();
        return p;
    }

    public IEnumerable<Painting> GetAllPaintings()
    {
        return _galleryContext.Painting.Include(u => u.User).ToList();
    }

    public Painting? GetPaintingById(int id)
    {
        return _galleryContext.Painting.Find(id);
    }

    public  IEnumerable<Painting> GetPaintingByName(string name)
    {
         return _galleryContext.Painting.Where(p => p.Name.Contains(name)).ToList();
    }

    public Painting UpdatePainting(Painting painting)
    {
        _galleryContext.Update(painting);
        _galleryContext.SaveChanges();        
        return _galleryContext.Painting.Find(painting.PaintingId);
    }
}