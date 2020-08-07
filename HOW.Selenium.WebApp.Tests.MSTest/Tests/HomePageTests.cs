using System;
using System.Collections.Generic;
using System.Text;
using HOW.Selenium.WebApp.Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HOW.Selenium.WebApp.Tests.MSTest.Tests
{
    [TestClass]
    public class HomePageTests : TestBase
    {
        [TestMethod]
        public void HomePage_Navigate_To_Page()
        {
            HomePage.GoTo();

            Assert.IsTrue(HomePage.IsAt);
        }

        [TestMethod]
        public void HomePage_Verify_Title_Use_Source()
        {
            var expectedTitle = "Home page";

            HomePage.GoTo();

            Assert.IsTrue(HomePage.IsTextPresent(expectedTitle));
        }

        [TestMethod]
        public void HomePage_Verify_Title_Use_TitleProp()
        {
            var expectedTitle = "Home page - HOW.Selenium.WebApp";

            HomePage.GoTo();

            Assert.IsTrue(HomePage.IsTitleValid(expectedTitle));
        }

        [TestMethod]
        public void HomePage_Navigate_To_PrivacyPage()
        {
            HomePage.GoTo();

            HomePage.ClickPrivacyLink();

            Assert.IsTrue(PrivacyPage.IsAt, "Failed to get to the privacy page");

        }

        [TestMethod]
        public void HomePage_Execute_Alert_And_Dimiss()
        {
            HomePage.GoTo();

            HomePage.ClickAlertFromExecuteJS();

            Assert.IsTrue(HomePage.IsAt);

        }
    }
}
