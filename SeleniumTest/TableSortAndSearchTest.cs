using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumEasyTest.SeleniumTest 
{
    public class TableSortAndSearchTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyHighestSalaryForSoftwareEngineer()
        {
            driver.Url = "https://www.seleniumeasy.com/test/table-sort-search-demo.html";
            driver.FindElement(By.XPath(".//table[@id='example']/tbody/tr/td[@data-order[1]]")).Click();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}



    

