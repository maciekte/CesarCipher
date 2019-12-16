using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Twitter_PF
{
    [TestFixture]
    public class ExtentReportDemo
    {
        [Test]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\Tobi\\source\\repos\\FirstTakeProgram\\Twitter_PF\\bin\\Debug\\extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("operating system", "windows 10");
            extent.AddSystemInfo("host name", "selenium PC");
            extent.AddSystemInfo("browser", "firefox");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "step 1: test case starts");
            test.Log(Status.Pass, "step 2: test case pass");
            test.Log(Status.Fail, "step 3: test case fail");
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");
            extent.Flush();
        }
    }
}
