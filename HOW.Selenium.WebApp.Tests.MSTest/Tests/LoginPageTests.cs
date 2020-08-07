using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using HOW.Selenium.WebApp.Framework.Pages;
using System.Threading;

namespace HOW.Selenium.WebApp.Tests.MSTest.Tests
{
    [TestClass]
    public class LoginPageTests : TestBase
    {
        [TestMethod]
        public void LoginPage_Attempt_Successful_Login()
        {
            LoginPage.GoTo();
            LoginPage.Login("a@a.com", "Pass@word1");
            Assert.IsTrue(HomePage.IsAt, "Failed to login and go to home page");
        }
    }
}
