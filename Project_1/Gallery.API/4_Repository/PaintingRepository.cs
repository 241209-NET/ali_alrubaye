using Gallery.API.Data;
using Gallery.API.DTO;
using Gallery.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Gallery.API.Repository;

public class PaintingRepository : IPaintingRepository{
    
    private readonly GalleryContext _galleryContext;

    public PaintingRepository(GalleryContext galleryContext) => _galleryContext = galleryContext;


    public Painting CreateNewPainting(PaintingDTO dto)
    {
        //retrieve the user. Check nullable in Service Layer
        var user = _galleryContext.User.FirstOrDefault(u=>u.UserId==dto.Owner_Artist_Id);

            var painting = new Painting{
                Name=dto.Title_Of_Painting,
                Price=dto.Price_Estimate,
                User=user!
            };        
            _galleryContext.Painting.Add(painting);
            _galleryContext.SaveChanges();

        return new Painting{
                Name=dto.Title_Of_Painting,
                Price=dto.Price_Estimate,
                User=user!
            };
    }

    public Painting DeletePaintingById(int id)
    {
        Painting? p = _galleryContext.Painting.FirstOrDefault(p=>p.PaintingId==id);
        _galleryContext.Painting.Remove(p!);
        _galleryContext.SaveChanges();
        return p!;
    }

    public IEnumerable<Painting> GetAllPaintings()
    {
        return _galleryContext.Painting.Include(u => u.User).ToList();
    }

    public Painting GetPaintingById(int id)
    {
        return _galleryContext.Painting.FirstOrDefault(p=>p.PaintingId==id)!;
    }

    public  IEnumerable<Painting> GetPaintingByName(string name)
    {
         return _galleryContext.Painting.Where(p => p.Name.Contains(name)).ToList();
    }
    

    public Painting UpdatePainting(PaintingUpdateDTO dto)
    {
        //retrieve the painting
        var painting = _galleryContext.Painting.FirstOrDefault(p=>p.PaintingId==dto.Id_Of_Painting);
        
                painting!.Name=dto.New_Title_Of_Painting;
                painting.Price=dto.New_Price_Estimate;
           

            _galleryContext.Painting.Update(painting!);
            _galleryContext.SaveChanges();
            return _galleryContext.Painting.FirstOrDefault(p=>p.PaintingId==dto.Id_Of_Painting)!;
        
        
        
    }
         
        
    
}