using FrameworkLibraries.Libraries;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TestFramework.PageObjectClasses;

namespace TestFramework.TestSuite
{

    public class LetsCodeTest:TestInit
    {
        PracticePage practicepage;

       

        [SetUp]
        public void SetupMethod()
        {
            StartAUT();
           // DriverContent.Driver = BroswerFactory.BrowserSelection("firefox", "https://letskodeit.teachable.com/p/practice");
            practicepage = new PracticePage();
          
            
            


            // GetReportsInstance();
            //TestProperties();
            // test = reportInstance.CreateTest("TestMethod1");

        }
        
       [Test]
        public void TestMethod1()
        {
            //Exception e;

          
               practicepage.clkBmwRadio();

           log.Info("dddddddddddddddddddddd");
                practicepage.SelectFromDropdown("index", "2");
           

            //log.Error("error");






            // DriverContent.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            practicepage.SelectFromDropdown("value", "benz");
            //Thread.Sleep(3000);
            practicepage.clckConfirmAlertbtn();
            //Thread.Sleep(3000);
            IAlert alert = DriverContent.Driver.SwitchTo().Alert();
            alert.Accept();

            practicepage.clckConfirmAlertbtn();
           // Thread.Sleep(3000);
            alert.Dismiss();
            
           // js.ExecuteScript("window.scrollBy(0, 400);");
            //Thread.Sleep(3000);
            //long height = (long)js.ExecuteScript("return window.innerHeight;");
            //long width = (long)js.ExecuteScript("return window.innerWidth;");
            //Console.WriteLine(height);
            //Console.WriteLine(width);
            //DriverContent.Driver.Quit();
        }

        [Test]
        public void Selected()
        {
           //test = reportInstance.CreateTest("Selected");
            //TestProperties();


            foreach (IWebElement item in practicepage.SelectDrpValues())
            {
                string ItemList = item.Text;
                Console.WriteLine(ItemList);
            }

            practicepage.SwitchWindow();
            practicepage.Entertxt("Abake is a good wife");
            practicepage.SwitchDefaultWindow();
        }

        [TearDown]
        public void afterMe()
        {
            log.Warn("Quiting browser drivers..");
            DriverContent.Driver.Quit();
        }
    }
}
