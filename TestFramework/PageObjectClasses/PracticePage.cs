using FrameworkLibraries.Libraries;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace TestFramework.PageObjectClasses
{
    class PracticePage : BaseConstructor
    {
        string parentHandle;


        [FindsBy(How = How.Id, Using = ("bmwradio"))]
        public IWebElement btnBmwRadio { get; set; }

        [FindsBy(How = How.Id, Using = ("benzradio"))]
        public IWebElement btnBenzRadio { get; set; }

        [FindsBy(How = How.Id, Using = ("hondaradio"))]
        public IWebElement btnHondaRadio { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("select[name='cars']"))]
        public IWebElement drpdwnCarSelection { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("option[value='apple']"))]
        public IWebElement MultiSelectionApple { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("option[value='orange']"))]
        public IWebElement MultiSelectionOrange { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("option[value='peach']"))]
        public IWebElement MultiSelectionPeach { get; set; }

        [FindsBy(How = How.Id, Using = ("benzcheck"))]
        public IWebElement btnBenzCheckbox { get; set; }

        [FindsBy(How = How.Id, Using = ("bmwcheck"))]
        public IWebElement btnBmwCheckbox { get; set; }

        [FindsBy(How = How.Id, Using = ("hondacheck"))]
        public IWebElement btnHondaCheckbox { get; set; }

        [FindsBy(How = How.Id, Using = ("openwindow"))]
        public IWebElement btnOpenWindow { get; set; }

        [FindsBy(How = How.Id, Using = ("opentab"))]
        public IWebElement btnOpenTab { get; set; }

        [FindsBy(How = How.Id, Using = ("search-courses"))]
        public IWebElement SrchBoxNewWindow { get; set; }

        [FindsBy(How = How.Id, Using = ("confirmbtn"))]
        public IWebElement btnConfirmAlert { get; set; }

        public void clckConfirmAlertbtn()
        {
            btnConfirmAlert.Click();
            

        }


        public void clkBmwRadio()
        {
            btnBmwRadio.Click();
        }


        public void SelectFromDropdown(string locatorType, string value)
        {
            SelectUtils.SelectElement(drpdwnCarSelection, locatorType, value);

        }

        public IList<IWebElement> SelectDrpValues()
        {
            return SelectUtils.GetDropdownValues(drpdwnCarSelection);

        }
        public void SwitchWindow()
        {
            SelectUtils.WindowSwitch(btnOpenWindow);
        }


        public void Entertxt(string message)
        {
            SrchBoxNewWindow.SendKeys(message);
            Thread.Sleep(4000);
            DriverContent.Driver.Close();

        }


        public void SwitchDefaultWindow()
        {

            SelectUtils.SwitchParentWindow();
            btnOpenWindow.Click();

        }




    }
}
