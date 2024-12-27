using Gallery.API.Model;
using Gallery.API.Repository;

namespace Gallery.API.Service;

public class UserService : IUserService{


    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

    public IEnumerable<User> GetAllOwners()
    {
        return _userRepository.GetAllUsers();
    }
}