using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace FrameworkLibraries.Libraries
{
    public class SelectUtils
    {
        private static SelectElement select;
        static string parentHandle;



        public static void SelectElement(IWebElement element, string Locator, string selection)
        {
            select = new SelectElement(element);
            if (Locator.Equals("value", StringComparison.InvariantCultureIgnoreCase))
            {

                select.SelectByValue(selection);
            }
            else if (Locator.Equals("text", StringComparison.InvariantCultureIgnoreCase))
            {
                // select = new SelectElement(element);
                select.SelectByText(selection);
            }
            else if (Locator.Equals("index", StringComparison.InvariantCultureIgnoreCase))
            {
                // select = new SelectElement(element);
                select.SelectByIndex(Int32.Parse(selection));
            }

        }

        public static IList<IWebElement> GetDropdownValues(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> SelectOption = select.Options;
            return SelectOption;
        }

        public static void WindowSwitch(IWebElement ClickNewWindowButton)
        {
            parentHandle = DriverContent.Driver.CurrentWindowHandle;
            Console.WriteLine("parent window is: " + parentHandle);
            ClickNewWindowButton.Click();
            IList<string> allHandles = DriverContent.Driver.WindowHandles;
            int size = allHandles.Count;
            Console.WriteLine(size);

            //Thread.Sleep(3000);

            foreach (string handle in allHandles)
            {
                Console.WriteLine("all window handles: " + handle);
                if (!handle.Equals(parentHandle))
                {
                    DriverContent.Driver.SwitchTo().Window(handle);
                    //Thread.Sleep(3000);
                    // SrchBoxNewWindow.SendKeys("abake");
                    break;
                }
            }
        }
        public static void SwitchParentWindow()
        {
            DriverContent.Driver.SwitchTo().Window(parentHandle);
        }
        public static IWebDriver ImplicitWait(double duration)
        {
            DriverContent.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(duration);
            return DriverContent.Driver;
        }
    }
}
