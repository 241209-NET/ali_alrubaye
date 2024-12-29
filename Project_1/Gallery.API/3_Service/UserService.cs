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
        
        // Role role = new Role{Name = "Admin"};
        // user.Role = role;
        return _userRepository.CreateNewUser(user);
    }
}