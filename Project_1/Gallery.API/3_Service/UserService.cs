using Gallery.API.CustomExceptions;
using Gallery.API.Model;
using Gallery.API.Repository;
using Microsoft.IdentityModel.Tokens;

namespace Gallery.API.Service;

public class UserService : IUserService{


    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public User CreateNewUser(User user){    

       List<string> rolesList = ["admin", "artist", "guest"];
       string roleInput = user.Role.ToLower();

       if (!rolesList.Contains(roleInput))
       {
        throw new Exception("user_Role must be: Admin, Artist, or Guest");
       } 
       if (user.Name.IsNullOrEmpty())
       {
          throw new Exception("Invalid user_name was entered!");
       }      

       return _userRepository.CreateNewUser(user);
    }

    public User? GetUserById(int id)
    {
        if (id<1)
        {
            throw new Exception("ID must be a positive integer!");
        }

        var u = _userRepository.GetUserById(id);

        if (u==null)
        {
            throw new UserNotFoundException("This user doesn't exist!");
        } 
        return u;
    }

    public User DeleteUserById(int id)
    {
        if (id<1)
        {
            throw new Exception("ID must be a positive integer!");
        }

        var u = _userRepository.GetUserById(id);

        if (u==null)
        {
            throw new UserNotFoundException("This user doesn't exist!");
        } 

        return _userRepository.DeleteUserById(id);
    }
}