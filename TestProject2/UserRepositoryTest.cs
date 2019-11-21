using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestProject2.BL;
using System.Linq;

namespace TestProject2
{
    public class UserRepositoryTest
    {
        UserRepository userRepo = new UserRepository();

        [Test]
        public void Returns_User_By_Id_Equals_1()
        {
            var user = TestData.LocalUsers1.FirstOrDefault();
            var userReturnedByMethod = userRepo.GetUserInfo(1);
            Assert.AreEqual(user, userReturnedByMethod);
        }

        [Test]
        public void Throws_Exception_When_Id_Equals_7()
        {
            Assert.Throws<NullReferenceException>(() => userRepo.GetUserInfo(7));
        }
    }
}
