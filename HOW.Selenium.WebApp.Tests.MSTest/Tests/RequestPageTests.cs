using HOW.Selenium.WebApp.Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HOW.Selenium.WebApp.Tests.MSTest.Tests
{
    [TestClass]
    public class RequestPageTests : TestBase
    {
        [TestMethod]
        public void RequestPage_Link_Visible_When_Logged_In()
        {
            HomePage.GoTo();

            var linkText = "Requests";


            Assert.IsFalse(HomePage.IsNavLinkPresent(linkText), "Link to request page was visible, but should not be");

            LoginPage.GoTo();
            LoginPage.Login("a@a.com", "Pass@word1");


            Assert.IsTrue(HomePage.IsNavLinkPresent(linkText), "Link to request page was NOT visible, but it should have been");
        }

        [TestMethod]
        public void RequestPage_Enter_New_Request_Form()
        {
            RequestPage.GoTo();

            LoginPage.Login("a@a.com", "Pass@word1");

            RequestPage.SubmitRequest("Request One", "My request info");

            Assert.IsTrue(HomePage.IsAt, "Failed to redirect to home page");

        }
    }
}
