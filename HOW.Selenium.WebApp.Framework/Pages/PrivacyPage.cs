using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HOW.Selenium.WebApp.Framework.Pages
{
    public static class PrivacyPage
    {

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl($"{Driver.BaseUrl}/Privacy");
        }

        public static bool IsAt
        {
            get
            {
                var header = Driver.Instance.FindElement(By.TagName("h1"));

                return (header.Text == "Privacy Policy");
            }
        }

        public static void ClickSubmitButton()
        {
            var buttonID = "Create_Alert";

            try
            {
                Driver.Instance.FindElement(By.Id("Date")).SendKeys("12/23/2020");
                IWebElement submitbutton = Driver.Instance.FindElement(By.Id(buttonID));
                submitbutton.Click();
            }
            catch (NoSuchElementException)
            {
                throw new ApplicationException($"Failed to find button with id = {buttonID}");
            }
        }

        public static bool IsAlertDisplayed()
        {
            try
            {
                IAlert alert = Driver.Instance.SwitchTo().Alert();
                alert.Accept();
                return true;
            }
            catch (Exception ex)
            {
                Helper.TakeScreenShot(Driver.Instance, nameof(IsAlertDisplayed));
                throw new NoAlertPresentException($"No alert display", ex);
            }


        }
    }
}
