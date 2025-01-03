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
        User? u = _galleryContext.User.FirstOrDefault(u=>u.UserId==id);
        _galleryContext.User.Remove(u!);
        _galleryContext.SaveChanges();
        return u!;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _galleryContext.User.Include(u => u.Paintings)
                .ToList();
        
        
    }

    public User? GetUserById(int id)
    {
        return _galleryContext.User.FirstOrDefault(u=>u.UserId==id);
    }

    
}