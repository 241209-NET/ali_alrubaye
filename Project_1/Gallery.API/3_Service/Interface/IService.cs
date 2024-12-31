using Gallery.API.Model;

namespace Gallery.API.Service;



public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User CreateNewUser(User user);
    User DeleteUserById(int id);
}

public interface IPaintingService{
     
     IEnumerable<Painting> GetAllPaintings();
     Painting CreateNewPainting(Painting painting);
     Painting GetPaintingById(int id);
     IEnumerable<Painting> GetPaintingByName(string name);
     Painting UpdatePainting(Painting painting);
     Painting DeletePaintingById(int id);
}