using FrameworkLibraries.Libraries;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQaProject.PageObjectClasses

{

    class HomePage : BaseConstructor
    {

        [FindsBy(How = How.LinkText, Using = ("Registration"))]
        public IWebElement lnkRegistration { get; set; }

        [FindsBy(How = How.LinkText, Using = ("Draggable"))]
        public IWebElement lnkDraggable { get; set; }

        [FindsBy(How = How.LinkText, Using = ("Resizable"))]
        public IWebElement lnkResizable { get; set; }

        [FindsBy(How = How.LinkText, Using = ("Tabs"))]
        public IWebElement lnkTabs { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = ("Frames"))]
        public IWebElement lnkFramesAndWindow { get; set; }

        public RegistrationPage ClckRegistration()
        {
            lnkRegistration.Click();
            return new RegistrationPage();
        }
    }


}
