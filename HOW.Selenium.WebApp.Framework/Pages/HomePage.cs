using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace HOW.Selenium.WebApp.Framework.Pages
{
    public static class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl($"{Driver.BaseUrl}/");
        }

        public static bool IsAt
        {
            get 
            {
                var header = Driver.Instance.FindElement(By.TagName("h1"));

                return (header.Text == "Welcome");
            }
        }

        public static bool IsTextPresent(string textToLocate)
        {
            return Driver.Instance.PageSource.Contains(textToLocate);
        }

        public static bool IsTitleValid(string expectedPageTitle)
        {
            return (Driver.Instance.Title == expectedPageTitle);
        }

        public static void ClickPrivacyLink()
        {
            var linkText = "Privacy";

            try
            {
                Driver.Instance.FindElement(By.LinkText(linkText)).Click();
            }
            catch (NoSuchElementException noex)
            {
                throw new ApplicationException($"Falid to find link with text ={linkText}", noex);
            }

        }

        public static bool IsNavLinkPresent(string linkText)
        {
            var links = Driver.Instance.FindElements(By.LinkText(linkText));

            return (links.Count > 0);

        }

        public static void ClickAlertFromExecuteJS()
        {
            ((IJavaScriptExecutor)Driver.Instance).ExecuteScript(
                "alert('executed from selenium executedriver');");

            IAlert alert = Driver.Instance.SwitchTo().Alert();
            Thread.Sleep(1500);
            alert.Accept();

        }
    }
}
