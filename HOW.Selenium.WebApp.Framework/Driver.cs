using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace HOW.Selenium.WebApp.Framework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseUrl { get; set; }

        public static void Initialize(
            string driverType,
            bool isPrivateMode = true,
            bool isHeadless = false)
        {
            switch (driverType)
            {
                case "Chrome":
                    var svc = ChromeDriverService.CreateDefaultService();
                    var chromeOptions = new ChromeOptions();
                    if (isPrivateMode)
                        chromeOptions.AddArgument("incognito");
                    if (isHeadless)
                        chromeOptions.AddArgument("headless");

                    chromeOptions.AddArgument("no-sandbox");

                    Instance = new ChromeDriver(svc, chromeOptions);
                    break;

                case "Firefox":
                    var ffsvc = FirefoxDriverService.CreateDefaultService();
                    var ffoptions = new FirefoxOptions
                    {
                        AcceptInsecureCertificates = true
                    };

                    if (isPrivateMode)
                        ffoptions.AddArgument("-private");
                    if (isHeadless)
                        ffoptions.AddArgument("-headless");

                    Instance = new FirefoxDriver(ffsvc, ffoptions);
                    break;

                default:
                    Instance = new ChromeDriver();
                    break;

            }

            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Quit()
        {
            Instance.Quit();
        }
    }
}
