using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTVAutomation
{
    [TestClass]
    public class LazyLoading
    {
        [TestMethod]
        public void TestLazyLoading()
        {
            IWebDriver webDriver = new ChromeDriver();
            int scrollLimit = 5;
            webDriver.Navigate().GoToUrl("https://onepagelove.com/tag/lazy-load");
            webDriver.Manage().Window.Maximize();
            ITakesScreenshot screenshotDriver = webDriver as ITakesScreenshot;


            for (int i = scrollLimit; i >= 0; i--)
            {
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/temp/Screenshot"+i+".png", ScreenshotImageFormat.Png);

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            }
            
            IWebElement elem = webDriver.FindElement(By.XPath("//a[@title='The Rollercoaster Life']"));
            var text = elem.Text;
            elem.Click();
            webDriver.Quit();

        }
        
    }
}
