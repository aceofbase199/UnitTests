using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using TestProject2.BL;

namespace TestProject2
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Throw_Exception_When_User_Not_Exist_In_Current_Context()
        {
            var userRepository = new UserRepository();
            Assert.That(() =>
            {
                userRepository.GetUserInfo(0);
            }, Throws.Exception);
        }
        [Test]
        public void Get_User_By_Id()
        {
            var mock = new Mock<IUserRepository>();
            mock.Setup(x => x.GetUserInfo(It.IsAny<int>())).Returns(new User());
            var actualUser = mock.Object.GetUserInfo(4);
            Assert.NotNull(actualUser);
        }
    }
}
