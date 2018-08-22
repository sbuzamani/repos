using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Common.Interfaces;
using Practice.Common;
using System.IO;
using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Practice1Tests
{
    [TestClass]
    public class InputUnitTests
    {
        [TestMethod]
        public void GetValue_ReturnsNumber_GivenValidStringValue()
        {
            using (StringReader sr = new StringReader(string.Format("3{0}", Environment.NewLine)))
            {
                Console.SetIn(sr);
                IInputStrategy inputStrategy = new ConsoleInputStrategy(4);
                int expeceted = 3;
                string.Format("Enter number less than 4: .{0}", Environment.NewLine);
                var number = inputStrategy.GetValue();
                Assert.AreEqual(expeceted, number);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void GetValue_DoesNotReturnNumber_GivenInvalidStringValue()
        {
            using (StringReader sr = new StringReader(string.Format("t{0}", Environment.NewLine)))
            {
                Console.SetIn(sr);
                IInputStrategy inputStrategy = new ConsoleInputStrategy(4);
                string.Format("Enter number less than 4: .{0}", Environment.NewLine);
                inputStrategy.GetValue();
            }
        }
    }
}
