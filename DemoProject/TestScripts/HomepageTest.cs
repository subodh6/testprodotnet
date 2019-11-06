using DemoProject.Base;
using DemoProject.Config;
using DemoProject.PagesUIElements;
using NUnit.Framework;
using System.Threading;

namespace DemoProject.TestScripts
{
    class HomepageTest
    {
        public TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [SetUp]
        public void Setup()
        {
            //TestContext.Parameters.Get(testContextInstance().);
            Driver.driver.Navigate().GoToUrl(Settings.URL);
            Driver.driver.Manage().Window.Maximize();

        }
        [Test]
        public void Test1()
        {
            HomePage page = new HomePage();
         
            page.EnterContactDetails(1, "Firstname", "Lastname", "Phonenumber", "Email");
            page.EnterMailingDetails(1, "Address",  "City",  "State",  "Postalcode", "Country");
            page.EnterUserDetails();

        }

        [TearDown]
        public void Stop()
        {
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
}
