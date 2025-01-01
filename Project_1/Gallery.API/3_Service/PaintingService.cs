using Gallery.API.CustomExceptions;
using Gallery.API.DTO;
using Gallery.API.Model;
using Gallery.API.Repository;
using Microsoft.IdentityModel.Tokens;

namespace Gallery.API.Service;

public class PaintingService(IPaintingRepository paintingRepository, IUserRepository userRepository) : IPaintingService {

    private readonly IPaintingRepository _paintingRespository = paintingRepository;
    private readonly IUserRepository _userRepository = userRepository;



    public Painting CreateNewPainting(PaintingDTO dto)
    {
        if (dto.Title_Of_Painting.IsNullOrEmpty())
        {
            throw new Exception("Title of painting must not be empty!");
        }
        if (dto.Owner_Artist_Id<1)
        {
            throw new Exception("ID must be a positive integer!");
        }
        if (dto.Price_Estimate<0)
        {
            throw new Exception("Price estimate must be a positive float OR zero!");
        }

        var u = _userRepository.GetUserById(dto.Owner_Artist_Id);
        if (u==null)
        {
            throw new UserNotFoundException("This user doesn't exist!");
        } 
        
        return _paintingRespository.CreateNewPainting(dto);
    }

   public Painting DeletePaintingById(int id)
    {
        if (id<1)
        {
            throw new Exception("ID must be a positive integer!");
        }

        var p = _paintingRespository.GetPaintingById(id);
        if (p==null)
        {
            throw new Exception("No such painting exists with this ID!");
        }
        return _paintingRespository.DeletePaintingById(id);
    }

    public IEnumerable<Painting> GetAllPaintings()
    {
        return _paintingRespository.GetAllPaintings();
    }

    public Painting GetPaintingById(int id)
    {
        if (id<1)
        {
            throw new Exception("ID must be a positive integer!");
        }

        var p = _paintingRespository.GetPaintingById(id);
        if (p==null)
        {
            throw new Exception("No such painting exists with this ID!");
        }

        return _paintingRespository.GetPaintingById(id);
    }

    public IEnumerable<Painting> GetPaintingByName(string name)
    {
        return _paintingRespository.GetPaintingByName(name);
    }

    public Painting UpdatePainting(PaintingUpdateDTO dto)
    {
        if (dto.Id_Of_Painting<1)
        {
            throw new Exception("ID of the painting must be a positive integer!");
        }

        var p = _paintingRespository.GetPaintingById(dto.Id_Of_Painting);
        if (p==null)
        {
            throw new Exception("No such painting exists with this ID!");
        }
        if (dto.New_Title_Of_Painting.IsNullOrEmpty())
        {
            throw new Exception("New title of painting must not be empty!");
        }
         if (dto.New_Price_Estimate<0)
        {
            throw new Exception("New price estimate must be a positive float OR zero!");
        }

        return _paintingRespository.UpdatePainting(dto);
    }




}