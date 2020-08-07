using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using HOW.Selenium.WebApp.Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HOW.Selenium.WebApp.Tests.MSTest.Tests
{
    [TestClass]
    public class PrivacyPageTests : TestBase
    {
        [TestMethod]
        public void PrivacyPage_Click_AlertButton()
        {
            PrivacyPage.GoTo();

            PrivacyPage.ClickSubmitButton();
            
            Assert.IsTrue(PrivacyPage.IsAlertDisplayed(), "Failed to display the alert");
        }
    }
}
