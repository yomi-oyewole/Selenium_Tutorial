using FrameworkLibraries.Libraries;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TestFramework.PageObjectClasses;

namespace TestFramework.TestSuite
{

    public class UnitTest1 : TestInit
    {
        PracticePage practicepage;
       

        [SetUp]
        public void SetupMethod()
        {
           StartAUT();
            // DriverContent.Driver = BroswerFactory.BrowserSelection("chrome", "https://letskodeit.teachable.com/p/practice");
            log.Info("Opening browser...");
            practicepage = new PracticePage();
            log.Info("initializing practicepage....");
            //GetReportsInstance();

        }

        [Test]
        public void Selected23()
        {
             //test = reportInstance.CreateTest("Selected32");
            //TestProperties();

            foreach (IWebElement item in practicepage.SelectDrpValues())
            {
                string ItemList = item.Text;
                Console.WriteLine(ItemList);
                log.Info("Items in the list: " + ItemList);

            }
            

            practicepage.SwitchWindow();
            log.Info("switched to new window");
            practicepage.Entertxt("Abake is a good wife");
            log.Info("enters values into search fields");
            practicepage.SwitchDefaultWindow();
            log.Info("switch back to default window");
            
            DriverContent.Driver.Quit();
            log.Warn("quiting all browsers");
            //reportInstance.Flush();
        }
    }
}
