using System;
using System.Linq;
using System.Web.Security;
using Boku.Models;
using Boku.Web.Controllers;
using Boku.Web.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Raven.Client;
using Raven.Client.Embedded;
using Raven.Client.Linq;

namespace Boku.Web.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        private IDocumentStore documentStore;
        private IDocumentSession documentSession;

        private AccountController accountController;

        private Mock<IMembershipService> membershipServiceMock;
        private Mock<IFormsAuthenticationService> formsAuthenticationServiceMock;
            
        [TestInitialize]
        public void TestSetup()
        {
            documentStore = new EmbeddableDocumentStore {RunInMemory = true};

            documentStore.Initialize();
            documentSession = documentStore.OpenSession();

            membershipServiceMock = new Mock<IMembershipService>();
            formsAuthenticationServiceMock = new Mock<IFormsAuthenticationService>();

            accountController = new AccountController(documentSession, membershipServiceMock.Object, formsAuthenticationServiceMock.Object);
        }

        [TestMethod]
        public void Register_Positive_Test()
        {
            // Arrange
            var registerModel = new RegisterModel
                {
                    UserName = "TestUser",
                    Email = "TestEmail",
                    Password = "TestPassword",
                    ConfirmPassword = "TestPassword"
                };

            MembershipCreateStatus outParam;
            membershipServiceMock.Setup(
                ms =>
                ms.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                              It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<object>(),
                              out outParam)).Returns(It.IsAny<MembershipUser>);

            // Act
            accountController.Register(registerModel);

            // Assert
            var res = documentSession.Query<RegisterModel>().Where(x => x.UserName == "TestUser").ToList();

            Assert.IsTrue(res.Count == 1);
            Assert.IsTrue(res[0].UserName == "TestUser");
        }

        [TestMethod]
        public void Register_Validate_User_Already_Exists()
        {
            // Arrange

            var registerModel = new RegisterModel
            {
                UserName = "TestUser",
                Email = "TestEmail",
                Password = "TestPassword",
                ConfirmPassword = "TestPassword"
            };

            MembershipCreateStatus outParam = MembershipCreateStatus.Success;
            membershipServiceMock.Setup(
                ms =>
                ms.CreateUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                              It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<object>(),
                              out outParam)).Returns(It.IsAny<MembershipUser>);

            // Act
            accountController.Register(registerModel);

        }
    }
}
