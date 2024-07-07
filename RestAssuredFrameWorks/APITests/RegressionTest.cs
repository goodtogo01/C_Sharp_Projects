using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAssuredFrameWorks;

namespace APITests
{
    [TestClass]
    public class RegressionTest
    {
     
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void Setup(TestContext testContext) {

            var dir = testContext.TestRunDirectory;
            Reporter.SetupExtentReport("API Regression Test Suit", "Full Regression Test Report", dir);
        }

        [TestInitialize]
        public void SetupTest() {

            Reporter.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void CleanupTest() {

           var testStatus = TestContext.CurrentTestOutcome;
            Status logStatus;

            switch (testStatus) {
                case UnitTestOutcome.Failed:
                    logStatus = Status.Fail;
                    Reporter.TestStatus(logStatus.ToString());  
                    break;
                case UnitTestOutcome.Passed:
                    logStatus = Status.Pass;
                    Reporter.TestStatus(logStatus.ToString());
                    break;
                case UnitTestOutcome.Inconclusive:
                    break;
                case UnitTestOutcome.InProgress: 
                    break;
                case UnitTestOutcome.Error:
                    break;
                case UnitTestOutcome.Timeout:
                    break;
                case UnitTestOutcome.Unknown:
                    break;
                case UnitTestOutcome.Aborted:
                    break;
                case UnitTestOutcome.NotRunnable:
                    break;
                default:
                    break;
                }
        }

        [ClassCleanup]
        public static void Cleanup() {
            Reporter.FlashReport();
        }


        [TestMethod]
        public void VerifyUsers() {

            var demo = new Demo<ListOfObjectDTO>();
            var user = demo.GetUsers("api/users?page=2");       
            Assert.AreEqual(2, user.Page);
            //Reporter.LogToReport(Status.Fail, "Page number doesnt matched!!");
            Assert.AreEqual("Michael", user.Data[0].first_name);
            //Reporter.LogToReport(Status.Fail, "User First_name doesnt Matched.");

        
        }

        [TestMethod]
        public void CreateNewUser()
        {

            string payload = @"{
                                ""name"": ""Donol"",
                                ""job"": ""Slave""
                                }";

            var user = new Helpers<CreateUserDTO>();

            var url = user.SetUrl("api/users");
            var request = user.PostRequest(payload);
            var response = user.GetResponse(url, request);

            CreateUserDTO content = user.GetContent<CreateUserDTO>(response);
            

            Assert.AreEqual("Donol", content.name);
            Assert.AreEqual("Slave", content.job);
        }

        [TestMethod]
        public void VerifyParticularUser() { 
        
            var de = new Demo<ListOfObjectDTO>();
            var user = de.GetUsers("api/users?page=2");
            Assert.AreEqual(2, user.Page);
            Assert.AreEqual("Lindsay", user.Data[1].first_name);

        }
    }
}
