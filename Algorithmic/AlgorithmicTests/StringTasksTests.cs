using Algorithmic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmicTests
{
    [TestClass]
    public class StringTasksTests
    {
        [TestMethod]
        public void SortAlphabet_324dDbBTtaA6_Return_2346AaBbDdTt()
        {
            char[] expected = { '2', '3', '4', '6', 'A', 'a', 'B', 'b', 'D', 'd', 'T', 't' };
            char[] actual = StringTasks.SortAlphabet("324dDbBTtaA6");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void SortAlphabet_324dDbбБBTtaA6_Return_2346AaBbDdTtБб()
        {
            char[] expected = { '2', '3', '4', '6', 'A', 'a', 'B', 'b', 'D', 'd', 'T', 't', 'Б', 'б' };
            char[] actual = StringTasks.SortAlphabet("324dDbбБBTtaA6");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void SortAlphabet_32dD3bбБB6_Return_2346AaBbDdTtБб()
        {
            char[] expected = { '3', '4', 'F', 'f', 'G', 'g' };
            char[] actual = StringTasks.SortAlphabet("fF43gG");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void SmallLettersInLarge_a_Return65_5()
        {
            Assert.AreEqual(65.5, StringTasks.SmallLettersInLarge('a'));
        }

        [TestMethod]
        public void SmallLettersInLarge_A_Return65()
        {
            Assert.AreEqual(65, StringTasks.SmallLettersInLarge('A'));
        }

        [TestMethod]
        public void SmallLettersInLarge_a_Return65()
        {
            Assert.AreNotEqual(65, StringTasks.SmallLettersInLarge('a'));
        }

        [TestMethod]
        public void Swap_2_1_B_A_Return_A_B()
        {
            char a = 'A';
            char b = 'B';
            char[] expected = { 'A', 'B' };
            char[] actual = StringTasks.Swap(2, 1, ref b, ref a);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void Swap_1_2_B_A_Return_B_A()
        {
            char a = 'A';
            char b = 'B';
            char[] expected = { b, a };
            char[] actual = StringTasks.Swap(1, 2, ref b, ref a);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void Swap_1_1_B_A_Return_B_A()
        {
            char a = 'A';
            char b = 'B';
            char[] expected = { b, a };
            char[] actual = StringTasks.Swap(1, 1, ref b, ref a);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
