using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Common;
using System;
using System.IO;

namespace Practice1Tests
{
    [TestClass]
    public class DisplayUnitTests
    {
        [TestMethod]
        public void Display_PrintsResult_GivenNumberIsPassed()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                DisplayStrategy displayStrategy = new DisplayStrategy();
                int answer = 5;
                displayStrategy.Display(answer);

                string expected = string.Format("The difference is 5", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }    
        }

        [TestMethod]
        public void Display_PrintsException_GivenExceptionIsPassed()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                DisplayStrategy displayStrategy = new DisplayStrategy();
                
                displayStrategy.Display(new Exception());
                string expected = string.Format("ERROR: Exception of type 'System.Exception' was thrown.", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
    }
}
