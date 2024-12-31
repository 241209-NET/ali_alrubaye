using Gallery.API.Model;

namespace Gallery.API.Service;



public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User CreateNewUser(User user);
    // User DeleteUserById(int id);
}