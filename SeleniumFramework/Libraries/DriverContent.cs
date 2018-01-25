using OpenQA.Selenium;

namespace FrameworkLibraries.Libraries
{
    public static class DriverContent
    {
        private static IWebDriver driver;
        
        public static IWebDriver Driver
        {
            get
            {
                return driver;

            }
            set
            {
                driver = value;
            }
        }
        
    }
}
