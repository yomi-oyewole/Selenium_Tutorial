
using OpenQA.Selenium.Support.PageObjects;


namespace FrameworkLibraries.Libraries
{
    public abstract class BaseConstructor
    {
        public BaseConstructor()
        {
            PageFactory.InitElements(DriverContent.Driver, this);
        }

        
    }
}
