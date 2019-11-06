using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using DemoProject.Config;
using DemoProject.Base;
using SeleniumExtras.PageObjects;
using How = SeleniumExtras.PageObjects.How;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using DemoProject.Helpers;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DemoProject.PagesUIElements
{

    public class HomePage : BasePage
    {


        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(2) > td:nth-child(2) > input")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(3) > td:nth-child(2) > input")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(4) > td:nth-child(2) > input")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#userName")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(7) > td:nth-child(2) > input")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(9) > td:nth-child(2) > input")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(10) > td:nth-child(2) > input")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(11) > td:nth-child(2) > input")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(12) > td:nth-child(2) > select")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(15) > td:nth-child(2) > input[type=password]")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(16) > td:nth-child(2) > input[type=password]")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(2) > table > tbody > tr:nth-child(5) > td > form > table > tbody > tr:nth-child(18) > td > input[type=image]")]
        public IWebElement SubmitButton { get; set; }

        public HomePage()
        {
            ExcelHelpers.PopulateInCollection();
        }



        public void EnterContactDetails(int rownum, string firstname, string lastname, string phone, string emailid)
        {


            if (FirstName.Displayed)
            {
                
                FirstName.Clear();
                FirstName.SendKeys(ExcelHelpers.ReadData(rownum, firstname));
                Console.WriteLine(FirstName.GetAttribute("value"));
            }
            if (LastName.Displayed)
            {
                LastName.Clear();
                LastName.SendKeys(ExcelHelpers.ReadData(rownum, lastname));
                Console.WriteLine(LastName.GetAttribute("value"));
            }
            if (Phone.Displayed)
            {
                Phone.Clear();
                Phone.SendKeys(ExcelHelpers.ReadData(rownum, phone));
                Console.WriteLine(Phone.GetAttribute("value"));
            }
            if (Email.Displayed)
            {
                Email.Clear();
                Email.SendKeys(ExcelHelpers.ReadData(rownum, emailid));
                Console.WriteLine(Email.GetAttribute("value"));
            }
        }

        public void EnterMailingDetails(int rownum, string address, string city, string state, string postalcode, string country)
        {


            if (Address.Displayed)
            {
                
                Address.Clear();
                Address.SendKeys(ExcelHelpers.ReadData(rownum, address));
                Console.WriteLine(Address.GetAttribute("value"));
            }
            if (City.Displayed)
            {
                City.Clear();
                City.SendKeys(ExcelHelpers.ReadData(rownum, city));
                Console.WriteLine(City.GetAttribute("value"));
            }
            if (State.Displayed)
            {
                State.Clear();
                State.SendKeys(ExcelHelpers.ReadData(rownum, state));
                Console.WriteLine(State.GetAttribute("value"));
            }
            if (PostalCode.Displayed)
            {
                PostalCode.Clear();
                PostalCode.SendKeys(ExcelHelpers.ReadData(rownum, postalcode));
                Console.WriteLine(PostalCode.GetAttribute("value"));
            }
            if (Country.Displayed)
            {
                new SelectElement(Country).SelectByText(ExcelHelpers.ReadData(rownum, country));
            }
        }

        public void EnterUserDetails()
        {
            string password = TestData.RandomPassword();

            if (Username.Displayed)
            {
              
                Username.Clear();
                Username.SendKeys(TestData.RandomUserName());
                Console.WriteLine(Username.GetAttribute("value"));
            }
            if (Password.Displayed)
            {
                Password.Clear();
                Password.SendKeys(password);
                Console.WriteLine(Password.GetAttribute("value"));
            }
            if (ConfirmPassword.Displayed)
            {
                ConfirmPassword.Clear();
                ConfirmPassword.SendKeys(password);
                Console.WriteLine(ConfirmPassword.GetAttribute("value"));
            }
            if (SubmitButton.Displayed)
            {
                SubmitButton.Click();
                Thread.Sleep(5000);
            }




        }

    }

}




