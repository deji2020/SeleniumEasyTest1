using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumEasyTest.ContactUsPage
{
    public class SeleniumEasyContactUsPage : BaseClass
    {
        private IWebElement logo;
        private IWebElement firstname;
        private IWebElement lastname;
        private IWebElement email;
        private IWebElement phone;
        private IWebElement Address;
        private IWebElement city;
        private IWebElement state;
        private IWebElement zip;
        private IWebElement website;
        private IWebElement hosting;
        private IWebElement projectDescription;
        private IWebElement sendbutton;
        

        public void AndIAmOnSeleniumEasyContactUsPage()
        {
            logo = GetElementById("site-name");

            Assert.True(logo.Displayed, "SeleniumEasy ContactUsPage is not displayed");
        }

        public void WhenIEnterValidFirstname()
        {
            firstname = GetElementByName("first_name");
            firstname.SendKeys("Boris");
        }

        public void AndIEnterValidLastName()
        {
            lastname = GetElementByName("last_name");
            lastname.SendKeys("Boris");
        }

        public void AndIEnterValidEmailAddress()
        {
            email = GetElementByName("email");
            email.SendKeys("abc@gmail.com");
        }

        public void AndIEnterValidPhoneNumber()
        {
            phone = GetElementByName("phone");
            phone.SendKeys("315-312-0578");
        }

        public void AndIEnterValidAddress()
        {
            Address = GetElementByName("address");
            Address.SendKeys("Oak Street");
        }

        public void AndIEnterValidCity()
        {
            city = GetElementByXpath(".//input[@name='city']");
            city.SendKeys("New York");
        }

        public void AndIEnterValidZipCode()
        {
            zip = GetElementByXpath(".//input[@name='zip']");
            zip.SendKeys("11428");
        }

        public void AndIEnterValidWebsite()
        {
            website = GetElementByXpath(".//input[@name='website']");
            website.SendKeys("https://www.whitehouse.gov/");
        }

        public void AndIClicktheRadioButton()
        {
            hosting = GetElementByXpath(".//input[@value='yes']");
            hosting.Click();
        }
        public void AndIEnterProductDescription()
        {
           projectDescription= GetElementByXpath(".//input[@value='yes']");
            projectDescription.SendKeys("Test Environment");
        }

        public void AndISelectState()
        {
            state = GetElementByXpath(".//select[@name='state']");
            SelectByVisibleText(state, "New York");
        }

        public void ThenIClickSendButton() 
        {
            sendbutton = GetElementByXpath(".//button[@class ='btn btn-default']");
            sendbutton.Submit();
        }
    }
}
