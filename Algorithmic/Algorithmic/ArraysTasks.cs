using System;

namespace Algorithmic
{
    /// <summary>
    ///  класс для работы с массивами
    /// </summary>
    public class ArraysTasks
    {
        static int arraySize = 10;  //размер одномерного массива
        static int[] array;  // одномерный массив

        // проверка на корректность ввода размера массива для чтения с консоли (тесты виснут из-за консоли)
      static void InputInvalidSizeArray(ref int size, string textConsole)
         {
             int number = 0;          
             try
             {
                 WorkWithTheConsole.InputInt32(textConsole, ref number);   
                 if (number <= 0)
                 {
                     WorkWithTheConsole.OutputError("ERROR. The size of the array must be a positive number\n");
                     InputInvalidSizeArray(ref size, textConsole);                    
                 }
                 else
                     size = number;                
             }
             catch (FormatException)
             {
                 WorkWithTheConsole.OutputError("DATA TYPE ERROR. Enter a number\n");
                 InputInvalidSizeArray(ref size, textConsole);
             }           
         }
 
        // проверка на корректность ввода размера массива для тестов
        internal static string InputInvalidSizeArrayTests( int sizeNumber)
        {
            string returnSize;
            if (sizeNumber <= 0)
            {
                returnSize = "ERROR. The size of the array must be a positive number";
                return returnSize;
            }
            else
            {
                returnSize = "array size = " + sizeNumber;
                return returnSize;
            }
        }
    

             // ввод одномерного массива
             static void InputOneDimensionalArray()
             {
                 InputInvalidSizeArray(ref arraySize, "Enter size massif: ");
                 array = new int[arraySize];
                 for (int i = 0; i < array.Length; i++)
                 {
                     WorkWithTheConsole.InputInt32("Enter " + i + " element massif: ", ref array[i]);
                 }
             }

             /// <summary>
             /// TASK: найти максимальную неубывающую последовательность
             /// </summary>
             static public void RunMaximumDoesNotDecreaseSequence()
             {
                 WorkWithTheConsole.OutputTitle("Найти максимальную неубывающую последовательность");
                 InputOneDimensionalArray();
                 MaximumDoesNotDecreaseSequence(array);
                 WorkWithTheConsole.ScreenDelay();
             }

             // поиск максимальной неубвающей последовательности
             internal static int[] MaximumDoesNotDecreaseSequence(int[] array)
             {
                 int iStartMax = 0;      // индекс 1-ого элемента макс последовательности
                 int iFinMax = 0;        // индекс последнего элемента макс последовательности
                 int amountMax = 0;      // максимальное количество элементов в макс последовательности
                 int amountCurrent = 0;  // максимальное количество элемонтов в тек последовательности
                 int iStartCurrent = 0;  // индекс 1-ого элемента текущей последовательности
                 int iFinCurrent = 0;    // индекс последнего элемента текущей последовательности
                 bool flag = false;              // флаг для проверки неубывающей последовательности

                 for (int i = 0; i < array.Length - 1; i++)
                 {
                     if (array[i] <= array[i + 1])
                     {
                         if (!flag)
                         {
                             flag = true;
                             iStartCurrent = i;
                         }

                         iFinCurrent = i + 1;
                         amountCurrent += 1;

                         if (amountCurrent > amountMax)
                         {
                             iStartMax = iStartCurrent;
                             iFinMax = i + 1;
                             amountMax = amountCurrent;
                         }
                     }
                     else
                     {
                         amountCurrent = 0;
                         flag = false;
                     }
                 }

                 WorkWithTheConsole.Output("Start array: ");
                 for (int i = 0; i < array.Length; i++)
                 {
                     WorkWithTheConsole.Output(" ");
                     WorkWithTheConsole.Output(array[i]);
                 }
                 WorkWithTheConsole.Output("\nStart index maximum sequence: ", iStartMax);
                 WorkWithTheConsole.Output("Finish index maximum sequence: ", iFinMax);
                 WorkWithTheConsole.Output("Maximum sequence: ");
                 for (int i = iStartMax; i <= iFinMax; i++)
                 {
                     WorkWithTheConsole.Output(" ");
                     WorkWithTheConsole.Output(array[i]);
                 }

                 // для тестов
                 int[] arrayTests = new int [iFinMax - iStartMax+1];
                 int j = 0;
                 for (int i = iStartMax; i <= iFinMax; i++)
                 {
                     arrayTests[j] = array[i];
                     ++j;
                 }
                 return arrayTests;
             }

             /// <summary>
             /// TASK: найти сумму второго наибольшего и второго наименьшего элемента массива
             /// </summary>
             static public void RunSummaTwoSmallestAndTwoLargestElementArray()
             {
                 WorkWithTheConsole.OutputTitle("Найти сумму второго наибольшего и второго наименьшего элемента массива");
                 InputOneDimensionalArray();
                 FindSummaTwoSmallestAndTwoLargestElementArray(array);
                 WorkWithTheConsole.ScreenDelay();
             }

             // поиск суммы второго наибольшего и второго наименьшего элемента массива
             internal static int FindSummaTwoSmallestAndTwoLargestElementArray(int[] array)
             {
                 int number = array[0];
                 bool flag = false;
                 Array.Sort(array);
                 for (int i = 1; i < array.Length; i++)
                 {
                     if (array[i] != number) flag = true;
                 }
                 if (flag)
                 {
                     WorkWithTheConsole.Output("The 2nd largest elements = ", array[1]);
                     WorkWithTheConsole.Output("The 2nd smallest element = ", array[array.Length - 2]);
                     WorkWithTheConsole.Output("The sum of the 2nd largest and 2nd smallest elements of the array = ", array[1] + array[array.Length - 2]);
                     return array[1] + array[array.Length - 2];
                 }
                 else
                 {
                     WorkWithTheConsole.Output("All elements are equal");
                     return array[1] + array[array.Length - 2];
                 }
             }
         }
     }
