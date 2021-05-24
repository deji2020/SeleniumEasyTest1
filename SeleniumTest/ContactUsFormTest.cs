using NUnit.Framework;
using SeleniumEasyTest.ContactUsPage;

namespace SeleniumEasyTest.SeleniumTest
{
    public class ContactUsFormTest
    {
        private SeleniumEasyContactUsPage SeleniumEasyContactUsPage;

        [SetUp]
        public void Initialise()
        {
            BaseClass.LaunchBrowser("Chrome");

        }

        [TearDown]
        public void TearDown()
        {
            BaseClass.CloseBrowser();
        }

        [Test]
        public void ContactUsPageTest()
        {
            SeleniumEasyContactUsPage = BaseClass.GivenINavigateToSeleniumEasyContactUsPage();
            SeleniumEasyContactUsPage.WhenIEnterValidFirstname();
            SeleniumEasyContactUsPage.AndIEnterValidLastName();
            SeleniumEasyContactUsPage.AndIEnterValidEmailAddress();
            SeleniumEasyContactUsPage.AndIEnterValidPhoneNumber();
            SeleniumEasyContactUsPage.AndIEnterValidAddress();
            SeleniumEasyContactUsPage.AndIEnterValidCity();
            SeleniumEasyContactUsPage.AndISelectState();
            SeleniumEasyContactUsPage.AndIEnterValidZipCode();
            SeleniumEasyContactUsPage.AndIEnterValidWebsite();
            SeleniumEasyContactUsPage.AndIClicktheRadioButton();
            SeleniumEasyContactUsPage.AndIEnterProductDescription();
            SeleniumEasyContactUsPage.ThenIClickSendButton();
        }
    }
}
