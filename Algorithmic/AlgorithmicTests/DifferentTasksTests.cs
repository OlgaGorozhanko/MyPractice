using Algorithmic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmicTests
{
    [TestClass]
    public class DifferentTasksTests
    {
        [TestMethod]
        public void NaturalNumber_3true_Return_3()
        {
            // arrange
            int number = 3;
            bool flag = true;
            //assert  
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_3false_Return_3()
        {
            // arrange
            int number = 3;
            bool flag = false;
            //assert  
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_0true_Return_0()
        {
            // arrange
            int number = 0;
            bool flag = true;
            //assert  
            Assert.AreEqual(0, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_0false_Return_0()
        {
            // arrange
            int number = 0;
            bool flag = false;
            //assert  
            Assert.AreEqual(0, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_minus3true_Return_3()
        {
            // arrange
            int number = -3;
            bool flag = true;
            // assert
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void NaturalNumber_minus3false_Return_3()
        {
            // arrange
            int number = -3;
            bool flag = false;
            // assert
            Assert.AreEqual(3, DifferentTasks.NaturalNumber(ref number, ref flag));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_minus3and4_Return1()
        {
            Assert.AreEqual(1, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(-3, 4));
        }

        [TestMethod]
        public void GreatestCommonDivisorEvclidAlgorithm_minus3andminus4_Return1()
        {
            Assert.AreEqual(1, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(-3, -4));
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
        public void GreatestCommonDivisorEvclidAlgorithm_1and0_Return0()
        {
            Assert.AreEqual(0, DifferentTasks.GreatestCommonDivisorEvclidAlgorithm(1, 0));
        }

        [TestMethod]
        public void PerfectNumberToFind_minus10_0_Return()
        {
            Assert.AreEqual("No perfect numbers", DifferentTasks.PerfectNumberToFind(-10, 0));
        }

        [TestMethod]
        public void PerfectNumberToFind_minus100_minus5_Return()
        {
            Assert.AreEqual("No perfect numbers", DifferentTasks.PerfectNumberToFind(-100, -5));
        }

        [TestMethod]
        public void PerfectNumberToFind_minus1_minus10_Return()
        {
            Assert.AreEqual("No perfect numbers", DifferentTasks.PerfectNumberToFind(-1, -10));
        }

        [TestMethod]
        public void PerfectNumberToFind_1_100_Return_6_28()
        {
            Assert.AreEqual("Perfect number:  " + 6 + " " + 28, DifferentTasks.PerfectNumberToFind(1, 100));
        }

        [TestMethod]
        public void PerfectNumberToFind_100_1_Return_6_28()
        {
            Assert.AreEqual("Perfect number:  " + 6 + " " + 28, DifferentTasks.PerfectNumberToFind(100, 1));
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

        [TestMethod]
        public void TranslationFromDecimalSystemToBinary_0_Return_0()
        {
            Assert.AreEqual("0", DifferentTasks.TranslationFromDecimalSystemToBinary(0));
        }

        [TestMethod]
        public void TranslationFromDecimalSystemToBinary_1_Return_1()
        {
            Assert.AreEqual("1", DifferentTasks.TranslationFromDecimalSystemToBinary(1));
        }

        [TestMethod]
        public void Factorial_1_Return_1()
        {
            Assert.AreEqual(1, DifferentTasks.Factorial(1));
        }

        [TestMethod]
        public void Factorial_0_Return_1()
        {
            Assert.AreEqual(1, DifferentTasks.Factorial(0));
        }

        [TestMethod]
        public void Factorial_2_Return_2()
        {
            Assert.AreEqual(2, DifferentTasks.Factorial(2));
        }

        [TestMethod]
        public void Factorial_7_Return_5040()
        {
            Assert.AreEqual(5040, DifferentTasks.Factorial(7));
        }

        [TestMethod]
        public void Factorial_minus2_Return_2()
        {
            Assert.AreEqual(0, DifferentTasks.Factorial(-2));
        }

        [TestMethod]
        public void Factorial_minus3_Return_2()
        {
            Assert.AreEqual(0, DifferentTasks.Factorial(-3));
        }

        [TestMethod]
        public void PrimeNumberCheck_3_Return_true()
        {
            Assert.AreEqual(true, DifferentTasks.PrimeNumberCheck(3));
        }

        [TestMethod]
        public void PrimeNumberCheck_1_Return_true()
        {
            Assert.AreEqual(true, DifferentTasks.PrimeNumberCheck(2));
        }

        [TestMethod]
        public void PrimeNumberCheck_11_Return_true()
        {
            Assert.AreEqual(true, DifferentTasks.PrimeNumberCheck(11));
        }

        [TestMethod]
        public void PrimeNumberCheck_4_Return_true()
        {
            Assert.AreEqual(false, DifferentTasks.PrimeNumberCheck(4));
        }

        [TestMethod]
        public void PrimeNumberCheck_12_Return_true()
        {
            Assert.AreEqual(false, DifferentTasks.PrimeNumberCheck(12));
        }

        [TestMethod]
        public void PrimeNumberCheck_minus3_Return_true()
        {
            Assert.AreEqual(false, DifferentTasks.PrimeNumberCheck(-3));
        }

        [TestMethod]
        public void PrimeNumberCheck_minus8_Return_true()
        {
            Assert.AreEqual(false, DifferentTasks.PrimeNumberCheck(-8));
        }

        [TestMethod]
        public void PrimeNumberCheck_0_Return_true()
        {
            Assert.AreEqual(false, DifferentTasks.PrimeNumberCheck(0));
        }

        [TestMethod]
        public void FactorialNumbersAsTheProductOfThreeConsecutivePrimes_3_Return_true()
        {
            Assert.AreEqual("1 * 2 * 3", DifferentTasks.FactorialNumbersAsTheProductOfThreeConsecutivePrimes(3));
        }

        [TestMethod]
        public void FactorialNumbersAsTheProductOfThreeConsecutivePrimes_5_Return_true()
        {
            Assert.AreEqual("can not imagine 5! = 120 as a product of three consecutive prime numbers", 
                DifferentTasks.FactorialNumbersAsTheProductOfThreeConsecutivePrimes(5));
        }

        [TestMethod]
        public void FactorialNumbersAsTheProductOfThreeConsecutivePrimes_0_Return_true()
        {
            Assert.AreEqual("can not imagine 0! = 1 as a product of three consecutive prime numbers", 
                DifferentTasks.FactorialNumbersAsTheProductOfThreeConsecutivePrimes(0));
        }

        [TestMethod]
        public void FactorialNumbersAsTheProductOfThreeConsecutivePrimes_minus3_Return_true()
        {
            Assert.AreNotEqual("1 * 2 * 3", DifferentTasks.FactorialNumbersAsTheProductOfThreeConsecutivePrimes(-2));
        }

    }
}
