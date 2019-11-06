using DemoProject.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace DemoProject.Base
{


    public static class Driver
    {

        public static IWebDriver driver = driver1();
       

        public static IWebDriver driver1()
        {

            IWebDriver driver1;
            ConfigReader.SetFrameworkSettings();

            switch (Settings.BROWSER)
            {
                case "chrome":
                    driver1 = new ChromeDriver(@"C:\Users\Neha.Sharma\source\repos\DemoProject\DemoProject\bin\Debug\netcoreapp2.1");
                    break;

                case "iexplorer":

                    driver1 = new InternetExplorerDriver();
                    break;
                default:
                    driver1 = new FirefoxDriver(@"C:\Users\Neha.Sharma\source\repos\DemoProject\DemoProject\bin\Debug\netcoreapp2.1");
                    break;
            }
            return driver1;



        }




    }
}
