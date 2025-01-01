using Gallery.API.Model;
using Gallery.API.Repository;
using Gallery.API.Service;
using Moq;

namespace Gallery.TEST;

public class UserServiceTests
{
    [Fact]
    public void TestCreateNewUser()
    {

        //arrange
        Mock<IUserRepository>  mockRepo = new();
        UserService userService = new(mockRepo.Object);

         List<User> userList = [
            new User{UserId=3, Name="testUserNameThree", Role="Admin", Paintings=[]},
            new User{UserId=4, Name="testUserNameFour", Role="Admin", Paintings=[]}           
        ];

        User u = new User{UserId=5, Name="testUserNameFive", Role="Admin", Paintings=[]};

        mockRepo.Setup(repo => repo.CreateNewUser(It.IsAny<User>()))
            .Callback((User user) => userList.Add(user))
            .Returns(u);
        
        //act
        var myUser = userService.CreateNewUser(u);

        //assert
        Assert.Contains(u, userList);
        mockRepo.Verify(a => a.CreateNewUser(It.IsAny<User>()), Times.Once());
        
        
    }

    
}