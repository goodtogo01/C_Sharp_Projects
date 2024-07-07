using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;


namespace RestAssuredFrameWorks
{
    public static class Reporter
    {
        public static ExtentReports extentReports;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReports;
        public static ExtentTest testCase;

    

        public static void SetupExtentReport(string reportName, string reportTitle, dynamic path) { 
            htmlReports = new ExtentHtmlReporter(path);
            htmlReports.Config.Theme = Theme.Standard;
            htmlReports.Config.DocumentTitle = reportTitle;
            htmlReports.Config.ReportName = reportName; 

            extent = new ExtentReports();
            extent.AttachReporter(htmlReports);
            extentReports=extent;       
        }
        public static void CreateTest(string testName) { 
        
            testCase = extentReports.CreateTest(testName);  
        }

        public static void LogToReport(Status status, string message)
        {
            testCase.Log(status, message);  
        }

        public static void FlashReport() {

            extentReports.Flush();
        }

        public static void TestStatus(string status) {

            if (status.Equals("Pass")){

                testCase.Pass("Test is Passed.");
            }
            else if(status.Equals("Fail")) {
                testCase.Fail("Test is Failed!!");
            }
        }


    }
}
