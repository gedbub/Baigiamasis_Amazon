using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            driver.Value = new ChromeDriver(options);
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-screenshot.png";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

            return screenshotFilePath;
        }
    }
}
