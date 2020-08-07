using System;
using System.Collections.Generic;
using System.Text;
using HOW.Selenium.WebApp.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HOW.Selenium.WebApp.Tests.MSTest
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize(
                TestContext.Properties["TargetBrowser"].ToString(),
                bool.Parse(TestContext.Properties["isPrivateMode"].ToString()),
                bool.Parse(TestContext.Properties["isHeadless"].ToString()));

            Driver.BaseUrl = TestContext.Properties["BaseUrl"].ToString();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
