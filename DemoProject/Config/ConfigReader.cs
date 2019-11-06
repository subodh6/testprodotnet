using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace DemoProject.Config
{
    public class ConfigReader
    {


        public static void SetFrameworkSettings()
        {
            XPathItem url;
            XPathItem browser;
            XPathItem excelpath;



            string strFileName = "C:\\Users\\pedinibhaskar\\Desktop\\DemoProject\\DemoProject\\Config\\GlobalConfig.xml";
            

            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            url = navigator.SelectSingleNode("DemoProject/RunSettings/URL");
            browser = navigator.SelectSingleNode("DemoProject/RunSettings/Browser");
            excelpath = navigator.SelectSingleNode("DemoProject/RunSettings/HomeExcelpath");

            //Set XML Details in the property to be used across framework
            Settings.URL = url.Value.ToString();
            Settings.BROWSER = browser.Value.ToString();
            Settings.EXCELPATH = excelpath.Value.ToString();
        }

      

    }
}
