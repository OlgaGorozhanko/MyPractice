using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic;

namespace AlgorithmicTests
{
    [TestClass]
    public class ArraysTasksTests
    {
        [TestMethod]
        public void SummaTwoSmallestAndTwoLargestElementArray_1_2_3_4_5_Return_6()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5 };
            //assert
            Assert.AreEqual("6", ArraysTasks.FindSummaTwoSmallestAndTwoLargestElementArray(array));
        }

        [TestMethod]
        public void SummaTwoSmallestAndTwoLargestElementArray_1_2_3_4_5_Return_5()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5 };
            //assert
            Assert.AreNotEqual("5", ArraysTasks.FindSummaTwoSmallestAndTwoLargestElementArray(array));
        }

        [TestMethod]
        public void SummaTwoSmallestAndTwoLargestElementArray_1_minus2_3_4_minus5_Return_5()
        {
            // arrange
            int[] array = { 1, -2, 3, 4, -5 };
            //assert
            Assert.AreEqual("1", ArraysTasks.FindSummaTwoSmallestAndTwoLargestElementArray(array));
        }

        [TestMethod]
        public void SummaTwoSmallestAndTwoLargestElementArray_1_1_1_1_1_Return_2()
        {
            // arrange
            int[] array = { 1, 1, 1, 1, 1 };
            //assert
            Assert.AreEqual("All elements are equal", ArraysTasks.FindSummaTwoSmallestAndTwoLargestElementArray(array));
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_10_1_1_1_1_Return_1_1_1_1()
        {
            // arrange
            int[] array = { 10, 1, 1, 1, 1 };
            int[] expected = { 1, 1, 1, 1};
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_10_1_1_1_1_minus3_Return_1_1_1_1()
        {
            // arrange
            int[] array = { 10, 1, 1, 1, 1, -3 };
            int[] expected = { 1, 1, 1, 1 };
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_1_2_3_1_2_3_4_5_1_2_Return_1_2_3_4_5()
        {
            // arrange
            int[] array = { 1, 2, 3, 1, 2, 3, 4, 5, 1, 2 };
            int[] expected = { 1, 2, 3, 4, 5 };
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_1_2_3_1_2_3_4_5_Return_1_2_3_4_5()
        {
            // arrange
            int[] array = { 1, 2, 3, 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert 
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_1_2_3_4_5_1_2_3_Return_1_2_3_4_5()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3 };
            int[] expected = { 1, 2, 3, 4, 5 };
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert 
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_1_1_1_1_1_Return_1_1_1_1_1()
        {
            // arrange
            int[] array = { 1, 1, 1, 1, 1 };
            int[] expected = { 1, 1, 1, 1, 1 };
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert 
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void MaximumDoesNotDecreaseSequence_4_3_2_1_Return_()
        {
            // arrange
            int[] array = { 4,3,2,1 };
            int[] expected = null;
            //act
            int[] actual = ArraysTasks.MaximumDoesNotDecreaseSequence(array);
            //assert 
            
                Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void InputInvalidSizeArrayTests_5_Return_5()
        {
            Assert.AreEqual("array size = 5", ArraysTasks.InputInvalidSizeArrayTests(5));
        }

        [TestMethod]
        public void InputInvalidSizeArrayTests_0_Return_0()
        {
            Assert.AreEqual("ERROR. The size of the array must be a positive number", ArraysTasks.InputInvalidSizeArrayTests(0));
        }

        [TestMethod]
        public void InputInvalidSizeArrayTests_minus5_Return_minus5()
        {
            Assert.AreEqual("ERROR. The size of the array must be a positive number", ArraysTasks.InputInvalidSizeArrayTests(-5));
        }

    }
}
