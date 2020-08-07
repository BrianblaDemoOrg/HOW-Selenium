using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HOW.Selenium.WebApp.Framework
{
    internal static class Helper
    {
        internal static void TakeScreenShot(IWebDriver driver, string fileName)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

            ss.SaveAsFile($"{fileName}-{DateTime.Now:yyyyMMddss}.png", ScreenshotImageFormat.Png);
        }

    }
}
