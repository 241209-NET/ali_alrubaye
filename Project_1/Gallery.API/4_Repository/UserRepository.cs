using Gallery.API.Data;
using Gallery.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Gallery.API.Repository;

public class UserRepository : IUserRepository{

    private readonly GalleryContext _galleryContext;

    public UserRepository(GalleryContext galleryContext) => _galleryContext = galleryContext;


    public User CreateNewUser(User user)
    {
            _galleryContext.Add(user);
            _galleryContext.SaveChanges();
            return user;
    }

    public User DeleteUserById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _galleryContext.User.Include(u => u.Paintings)
            .ToList();
        
        
    }

    public User? GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}