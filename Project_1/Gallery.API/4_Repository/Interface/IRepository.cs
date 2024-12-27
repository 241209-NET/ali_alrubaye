using Gallery.API.Model;

namespace Gallery.API.Repository;

public interface IUserRepository{

    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User CreateNewUser(User user);
    User DeleteUserById(int id);  
    User UpdateUser(User user); 
    
}

public interface IPaintingRepository{
     
}

public interface IRoleRepository{

}
