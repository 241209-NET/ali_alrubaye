using Gallery.API.Model;
using Gallery.API.Repository;

namespace Gallery.API.Service;

public class UserService : IUserService{


    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public User CreateNewUser(User user){        
       return _userRepository.CreateNewUser(user);
    }

    public User? GetUserById(int id)
    {
        return _userRepository.GetUserById(id);
    }

    public User DeleteUserById(int id)
    {
        return _userRepository.DeleteUserById(id);
    }
}