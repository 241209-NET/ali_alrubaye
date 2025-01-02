using Gallery.API.DTO;
using Gallery.API.Model;
using Gallery.API.Repository;
using Gallery.API.Service;
using Moq;

namespace Gallery.TEST;

public class ServiceTests
{
    [Fact]
    public void TestCreateNewUserSucessful()
    {

        //arrange
        Mock<IUserRepository>  mockUserRepo = new();
        UserService userService = new(mockUserRepo.Object);

         List<User> userList = [
            new User{UserId=3, Name="testUserNameThree", Role="Admin", Paintings=[]},
            new User{UserId=4, Name="testUserNameFour", Role="Admin", Paintings=[]}           
        ];

        User u = new User{UserId=5, Name="testUserNameFive", Role="Admin", Paintings=[]};

        mockUserRepo.Setup(repo => repo.CreateNewUser(It.IsAny<User>()))
            .Callback((User user) => userList.Add(user))
            .Returns(u);
        
        //act
        var myUser = userService.CreateNewUser(u);

        //assert
        Assert.Contains(u, userList);
        mockUserRepo.Verify(a => a.CreateNewUser(It.IsAny<User>()), Times.Once());        
    }

    [Fact]
    public void TestGetAllUsersSuccessful(){
        
        
        //arrange
        Mock<IUserRepository> mockUserRepo = new();
        UserService userService = new(mockUserRepo.Object);

        List<User> userList = [
            new User{UserId = 1, Role = "Admin", Name= "adm", Paintings=[]},
            new User{UserId = 2, Role = "Artist", Name= "art", Paintings=[]},
            new User{UserId = 3, Role = "Guest", Name= "gst", Paintings=[]}
        ];

        mockUserRepo.Setup(repo => repo.GetAllUsers()).Returns(userList);

        //act
        var result = userService.GetAllUsers().ToList();

        //assert
        Assert.Equal(userList, result);


    }


    [Fact]
    public void TestGetUserByIdSuccessful(){



        //arrange
        Mock<IUserRepository> mockUserRepo = new();
        UserService userService = new(mockUserRepo.Object);

        User u = new User{UserId = 1, Role = "Admin", Name= "adm", Paintings=[]};

        mockUserRepo.Setup(repo => repo.GetUserById(u.UserId)).Returns(u);


        //act
        var result = userService.GetUserById(u.UserId);

        //assert
        Assert.Equal(u, result);


    }


    [Fact]
    public void TestGetAllPaintingsSuccessful(){



        //arrange
        Mock<IPaintingRepository> mockPaintingRepo = new();
        Mock<IUserRepository> mockUserRepo = new();
        PaintingService paintingService = new(mockPaintingRepo.Object, mockUserRepo.Object);
        
        User u = new User{UserId = 1, Role = "Admin", Name= "adm", Paintings=[]};

        List<Painting> pList = [
            new Painting{PaintingId=1, Name="p1", Price=2.29, User=u},
            new Painting{PaintingId=2, Name="p2", Price=5.44, User=u},
            new Painting{PaintingId=3, Name="p3", Price=6.33, User=u}
        ];

        u.Paintings=pList;

        mockPaintingRepo.Setup(repo => repo.GetAllPaintings()).Returns(pList);

        //act
        var result = paintingService.GetAllPaintings();

        //assert
        Assert.Equal(pList, result);

    }

    [Fact]
    public void TestDeleteUserByIdSuccessful(){

        //arrange
        Mock<IUserRepository> mockUserRepo = new();
        UserService userService = new(mockUserRepo.Object);

         List<User> userList = [
            new User{UserId=3, Name="deleteMe", Role="Admin", Paintings=[]},
            new User{UserId=4, Name="testUserNameFour", Role="Admin", Paintings=[]}           
        ];

        User deleteMe = new User{UserId=3, Name="deleteMe", Role="Admin", Paintings=[]};
        

        mockUserRepo.Setup(repo => repo.GetUserById(deleteMe.UserId)).Returns(deleteMe);
        mockUserRepo.Setup(repo => repo.DeleteUserById(3))
            .Callback(() => userList.Remove(deleteMe))
            .Returns(deleteMe);

        //act
        var deleteMeTest = userService.DeleteUserById(3);

        //assert
        Assert.DoesNotContain(deleteMeTest, userList);
        mockUserRepo.Verify(a => a.DeleteUserById(3), Times.Once());  

    }


    [Fact]
    public void TestUpdatePaintingSuccessful(){

        //arrange
        Mock<IPaintingRepository> mockPaintingRepo = new();
        Mock<IUserRepository> mockUserRepo = new();
        PaintingService paintingService = new(mockPaintingRepo.Object, mockUserRepo.Object);

        User u = new User{UserId = 1, Role = "Admin", Name= "adm", Paintings=[]};

        List<Painting> pList = [
            new Painting{PaintingId=1, Name="p1", Price=2.29, User=u},
            new Painting{PaintingId=2, Name="p2", Price=5.44, User=u},
            new Painting{PaintingId=3, Name="p3", Price=6.33, User=u}
        ];

        u.Paintings=pList;

        Painting toBeUpdated = new Painting{PaintingId=2, Name="p2", Price=5.44, User=u};
        Painting updatedTo = new Painting{PaintingId=2, Name="got updated", Price=5.44, User=u};


        mockPaintingRepo.Setup(repo => repo.GetPaintingById(toBeUpdated.PaintingId)).Returns(toBeUpdated);       

        PaintingUpdateDTO theUpdateDTO = new(){
            Id_Of_Painting=toBeUpdated.PaintingId,
            New_Title_Of_Painting="got updated",
            New_Price_Estimate=toBeUpdated.Price
            };
        
        mockPaintingRepo.Setup(repo => repo.UpdatePainting(theUpdateDTO))
                .Callback(() => {
                    pList.Remove(toBeUpdated);
                    pList.Add(updatedTo);
                    })
                .Returns(updatedTo);

        //act
        var updatedTest = paintingService.UpdatePainting(theUpdateDTO);

        //assert
        Assert.Equal(updatedTo.Name,updatedTest.Name);

    }


}