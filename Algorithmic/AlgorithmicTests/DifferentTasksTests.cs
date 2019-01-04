using Algorithmic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmicTests
{
    [TestClass]
    public class DifferentTasksTests
    {
        [TestMethod]
        public void NaturalNumber_3_Return_3()
        {
            // arrange
            int number = 3;
            bool flag = true;
            //assert  
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_0_Return_0()
        {
            // arrange
            int number = 0;
            bool flag = true;
            //assert  
            Assert.AreEqual(0, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_minus3_Return_3()
        {
            // arrange
            int number = -3;
            bool flag = true;
            // assert
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_minus3and4_Return1()
        {
            Assert.AreEqual(1, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(-3, 4));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_2and158_Return2()
        {
            Assert.AreEqual(2, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(2, 158));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_2and15_Return1()
        {
            Assert.AreEqual(1, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(2, 15));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_0and0_Return0()
        {
            Assert.AreEqual(0, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(0, 0));
        }

        [TestMethod]
        public void PerfectNumberToFind_minus10_0_Return()
        {
            Assert.AreEqual("No perfect numbers", DifferentTasks.PerfectNumberToFind(-10, 0));
        }

        [TestMethod]
        public void PerfectNumberToFind_1_100_Return_6_28()
        {
            Assert.AreEqual("Perfect number:  " + 6 + " " + 28, DifferentTasks.PerfectNumberToFind(1, 100));
        }

        [TestMethod]
        public void TranslationFromDecimalSystemToBinary_6_Return_110()
        {
            Assert.AreEqual("110", DifferentTasks.TranslationFromDecimalSystemToBinary(6));
        }

        [TestMethod]
        public void TranslationFromDecimalSystemToBinary_minus5_Return_minus101()
        {
            Assert.AreEqual("-101", DifferentTasks.TranslationFromDecimalSystemToBinary(-5));
        }
    }
}
