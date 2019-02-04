using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic;

namespace AlgorithmicTests
{
    [TestClass]
    public class WorkWithTheConsoleTests
    {
        [TestMethod]
        public void InputInt32Tests_1_Return_1()
        {
            object value = 1;
            Assert.AreEqual("1", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests_minus1_Return_1()
        {
            object value = -1;
            Assert.AreEqual("-1", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests_0_Return_0()
        {
            object value = 0;
            Assert.AreEqual("0", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests__Return_0000000()
        {
            object value = "";
            Assert.AreEqual("DATA TYPE ERROR. Enter a number", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests_DSEFWF_Return_0000000()
        {
            object value = "DSEFWF";
            Assert.AreEqual("DATA TYPE ERROR. Enter a number", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests_Simbol_Return_0000000()
        {
            object value = "#$^$#";
            Assert.AreEqual("DATA TYPE ERROR. Enter a number", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void InputInt32Tests_Return_0000000()
        {
            object value = "            ";
            Assert.AreEqual("DATA TYPE ERROR. Enter a number", WorkWithTheConsole.InputInt32Tests(ref value));
        }

        [TestMethod]
        public void OutputTitle_text_Return_text()
        {
            
            Assert.AreEqual("\n\t\tTASK: \n", WorkWithTheConsole.OutputTitle(""));
        }

        [TestMethod]
        public void OutputTitle_text1_Return_text()
        {

            Assert.AreEqual("\n\t\tTASK:    \n", WorkWithTheConsole.OutputTitle("   "));
        }

        [TestMethod]
        public void OutputTitle_AAA_Return_text()
        {

            Assert.AreEqual("\n\t\tTASK: AAA\n", WorkWithTheConsole.OutputTitle("AAA"));
        }

        [TestMethod]
        public void OutputTitle_123_Return_text()
        {

            Assert.AreEqual("\n\t\tTASK: 123\n", WorkWithTheConsole.OutputTitle("123"));
        }

        [TestMethod]
        public void OutputTitle_Simbol_Return_text()
        {

            Assert.AreEqual("\n\t\tTASK: @#$!@\n", WorkWithTheConsole.OutputTitle("@#$!@"));
        }

    }
}
