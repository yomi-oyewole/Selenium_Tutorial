using OpenQA.Selenium;

namespace FrameworkLibraries.Libraries
{
    public class TestInit
    {
        public static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static readonly string AUT = "https://letskodeit.teachable.com/p/practice";
        public static readonly string Browser = "chrome";
        public IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContent.Driver;
        /* public  ExtentReports reportInstance;
         public  ExtentHtmlReporter htmlreports;
         public ExtentTest test;*/


        public static void StartAUT()
        {
            DriverContent.Driver = BroswerFactory.BrowserSelection(Browser, AUT);
        }

       
      /*  public ExtentReports GetReportsInstance()
        {
            string path = @"c:\Users\Benjamin\Desktop\yomi1.html";
            htmlreports = new ExtentHtmlReporter(path);
            reportInstance = new ExtentReports();
            reportInstance.AttachReporter(htmlreports);
            return reportInstance;
        }

        public void TestProperties()
        {
           // test = reportInstance.CreateTest("Correct username and pass");
            test.AssignAuthor("Oyewole Yomi");
            reportInstance.AddSystemInfo("Host Name", "Benjamin");
            reportInstance.AddSystemInfo("Envirionment", "QA");
            htmlreports.Configuration().DocumentTitle = "Login Functionality";
            htmlreports.Configuration().ReportName = "Regression Test";

        }*/


    }
}
