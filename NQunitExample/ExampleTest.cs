using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NQunitExample
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod,
        DeploymentItem(@"NQunitExample\ExampleTest.html"),
        DeploymentItem(@"NQunitExample\Content\qunit.css", @"Content"),
        DeploymentItem(@"NQunitExample\Scripts\qunit.js", @"Scripts")]
        public void TestMethod1()
        {
            var files = new string[] { Path.Combine(TestContext.DeploymentDirectory, "ExampleTest.html") };
            var tests = NQUnit.NQUnit.GetTests(30 * 1000, files);
            foreach (var item in tests)
            {
                if (item.InitializationException != null)
                    throw new Exception("Intialization Exception", item.InitializationException);
                Assert.AreEqual("pass", item.Result, item.Message);
            }
        }

        public TestContext TestContext { get; set; }
    }
}
