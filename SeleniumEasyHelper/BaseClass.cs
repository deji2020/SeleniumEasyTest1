using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumEasyTest.ContactUsPage;
using System;
using System.Threading;

namespace SeleniumEasyTest
{
    public class BaseClass
    {
        private static IWebDriver driver;
        private static SelectElement select;

        static BaseClass()
        {
            driver = null;
            select = null;
        }

        public static void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = InitChrome();
                    break;
                case "FireFox":
                    driver = InitFirefox();
                    break;
                default:
                    Console.WriteLine(browser + "is not recongnised. So Firefox is launched instead");
                    driver = InitFirefox();
                    break;
            }

            driver.Manage().Window.Maximize();
        }
        private static IWebDriver InitChrome()
        {
            driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver InitFirefox()
        {
            driver = new FirefoxDriver();
            return driver;
        }

        public static void LaunchURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }

        public static void SelectByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public static void SelectByVisibleText(IWebElement element, string text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }


        public static void SelectByValue(IWebElement element, string value)
        {
            select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public static IWebElement GetElementById(string id)
        {
            By locator = By.Id(id);
           return GetElement(locator);
        }

        public static IWebElement GetElementByName(string name)
        {
            By locator = By.Name(name);
            return GetElement(locator);
        }

        public static IWebElement GetElementByXpath(string xpath)
        {
            By locator = By.XPath(xpath);
            return GetElement(locator);
        }
        private static IWebElement GetElement(By Locator)
        {
            IWebElement element = null;
            int tryCount = 0;

            while (element == null)
            {
                try
                {
                    element = driver.FindElement(Locator);
                }
                catch (Exception e)
                {
                    if (tryCount == 1)
                    {
                        TakeScreenshot();
                        throw e;
                    }
                }

                var waitTime = new TimeSpan(0, 0, 1);
                Thread.Sleep(waitTime);

                tryCount++;
            }
            Console.WriteLine(element.ToString() + " is now retrieved ");
            return element;
        }

        private static Screenshot TakeScreenshot() 
        {
            return ((ITakesScreenshot)driver).GetScreenshot();
        }

        public static SeleniumEasyContactUsPage GivenINavigateToSeleniumEasyContactUsPage() 
        {
            LaunchURL("https://www.seleniumeasy.com/test/input-form-demo.html");
            return new SeleniumEasyContactUsPage();
        }
    }  
}
