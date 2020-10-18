using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GameTVAutomation.Entitiy;
using ConsoleTables;

namespace GameTVAutomation
{
    [TestClass]
    public class ImageBrokenCheck
    {
        [TestMethod]
        public void BrokenImageTest()
        {
            IWebDriver webDriver = new ChromeDriver();

            webDriver.Navigate().GoToUrl("https://game.tv");
            webDriver.Manage().Window.Maximize();

            List<IWebElement> imagesList = webDriver.FindElements(By.TagName("img")).ToList();
            Console.WriteLine("Total no. of images are " + imagesList.Count);
            var invalidImageCount = 0;
            foreach (IWebElement imgElement in imagesList)
            {
                if (imgElement != null)
                {
                    
                        var client = (HttpWebRequest)WebRequest.Create(webDriver.Url);
                        var response = (HttpWebResponse)client.GetResponse();
                        // verifying response code he HttpStatus should be 200 if not, 
                        // increment as invalid images count 

                        if (response.StatusCode.ToString() != "OK")
                            invalidImageCount++;
                  
                  
                }
            }

            Console.WriteLine("Total no. of invalid images are " + invalidImageCount);
            webDriver.Quit();

        }
    }
}
