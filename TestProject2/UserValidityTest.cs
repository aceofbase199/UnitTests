using System;
using System.Collections.Generic;
using System.Text;
using TestProject2.BL;
using NUnit.Framework;
using System.Linq;

namespace TestProject2
{
    class UserValidityTest
    {
        [Test]
        public void User_Exists()
        {
            var user = new User() { Id = 3, UserName = "test3", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 6 };
            var exists = TestData.LocalUsers1.Any(x => x.Id == user.Id 
                                                  && x.UserName.Equals(user.UserName) 
                                                  && x.CompanyId == user.CompanyId
                                                  && x.ContactId == user.ContactId);
            Assert.AreEqual(true, exists);
        }

        [Test]
        public void User_Does_Not_Exist()
        {
            var user = new User() { Id = 3, UserName = "test10", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 6 };
            var exists = TestData.LocalUsers1.Any(x => x.Id == user.Id
                                                  && x.UserName.Equals(user.UserName)
                                                  && x.CompanyId == user.CompanyId
                                                  && x.ContactId == user.ContactId);
            Assert.AreEqual(false, exists);
        }
    }
}
