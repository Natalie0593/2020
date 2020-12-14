using BlogHost.Controllers;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BlogHost.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<UserManager<User>>();
            var userManager = new Mock<UserManager<User>>();

            mock.Setup(@object => @object.GetAll()).Returns(GetTestUsers());
            var controller = new UsersController(mock.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
            Assert.Equal(GetTestUsers().Count, model.Count());

        }

        private List<User> GetTestUsers()
        {
            var users = new List<User>
                    {
                        new User {Id = "testUserId", Name="Tom", SecondName="Rwdrh",Year=12,Gender="b",Profession="jjg",ImgUrl="jyh", Avatar = new byte[2] ,DateRegistration = DateTime.Now},

                    };
            return users;
        }
        [Fact]
        public void GetUserReturnsNotFoundResultWhenUserNotFound()
        {
            // Arrange
            string testUserId = "1";
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<UserManager<User>>();
            mock.Setup(@object => @object.GetUserDB(testUserId))
                .Returns(null as User);
            var controller = new UsersController(mock.Object);

            // Act
            var result = controller.GetUser("testUserId");

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void GetUserReturnsViewResultWithUser()
        {
            // Arrange
            int testUserId = 1;
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<UserManager<User>>();
            mock.Setup(@object => @object.GetUserDB("testUserId"))
                .Returns(GetTestUsers().FirstOrDefault(p => p.Id == "testUserId"));
            var controller = new UsersController(mock.Object);

            // Act
            var result = controller.GetUser("testUserId");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<User>(viewResult.ViewData.Model);
            Assert.Equal("Tom", model.Name);
            Assert.Equal(12, model.Year);
            Assert.Equal("testUserId", model.Id);
        }

        [Fact]
        public void GetUserReturnsBadRequestResultWhenIdIsNull()
        {
            // Arrange
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<UserManager<User>>();
            var controller = new UsersController(mock.Object);

            // Act
            var result = controller.GetUser(null);

            // Arrange
            Assert.IsType<BadRequestResult>(result);
        }
    }
}


