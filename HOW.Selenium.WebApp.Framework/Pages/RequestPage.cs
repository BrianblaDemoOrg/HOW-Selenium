using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace HOW.Selenium.WebApp.Framework.Pages
{
    public class RequestPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl($"{Driver.BaseUrl}/Requests");
        }

        public static bool IsAt
        {
            get
            {
                var header = Driver.Instance.FindElement(By.TagName("h1"));

                return (header.Text == "Requests");
            }
        }

        public static void SubmitRequest(string title, string body)
        {
            try
            {

                Driver.Instance.FindElement(By.Id("Title")).SendKeys(title);
                Driver.Instance.FindElement(By.Id("Body")).SendKeys(body);

                new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 5))
                    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Create_Request"))).Click();
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new ApplicationException($"Timed out when trying to click on Create Request button", ex);
            }


        }

    }
}
