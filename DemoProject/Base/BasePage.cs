using DemoProject.Config;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace DemoProject.Base
{
    public class BasePage
    {

        public BasePage()
        {
            IWebDriver driver = Driver.driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(120)));
        }


    }
}
