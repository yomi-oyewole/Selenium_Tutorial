using FrameworkLibraries.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQaProject.ProjectSetup
{
    public class ProjectConfig
    {
        private static readonly string AUT = "http://demoqa.com/";
        private static readonly string Browser = "chrome";

        public static void StartAUT()
        {
            DriverContent.Driver = BroswerFactory.BrowserSelection(Browser, AUT);
        }

       
    }
}
