using System;

namespace Algorithmic
{
    /// <summary>
    /// rus: различные задачи на алгоритмику
    /// </summary>
    class DifferentTasks
    {
        /// <summary>
        /// TASK: определить являются ли целые числа взаимпнопростыми
        /// </summary> 
        static public void RunMutuallySimpleNumber()
        {
            WorkWithTheConsole.OutputTitle("Определить являются ли целые числа взаимпнопростыми");
            InputWholeNumbers();
            GreatestCommonDivisorEvclidAlgorithm( firstNumber, secondNumber);    
        }

        static int firstNumber;
        static int secondNumber;
        static bool naturalNumberFlag = false;
        static int NOD;


        // ввод двух целых чисел
        static void InputWholeNumbers()
        {
            WorkWithTheConsole.InputInt32("Enter 2 whole numbers\number 1st number = ", ref firstNumber);
            WorkWithTheConsole.InputInt32(" 2st number = ", ref secondNumber);           
        }

        // модуль натурального числа
        internal static int NaturalNumber(ref int number, ref bool naturalNumberFlag)
        {
            number = Math.Abs(number);
            if (number == 0)
            {
                naturalNumberFlag = true;
            }
            return number;
        }

        // алгоритм поиска НОД (Наибольший общий делитель)
        internal static double GreatestCommonDivisorEvclidAlgorithm(int firstNumber, int secondNumber)
        {
            naturalNumberFlag = false;
            NaturalNumber(ref firstNumber, ref naturalNumberFlag);
             NaturalNumber(ref secondNumber, ref naturalNumberFlag);
            if (naturalNumberFlag == true)
            {
                OutputMutuallySimpleNumbers();
                return 0;
            }
            else if (firstNumber > secondNumber)
            {
                if (firstNumber % secondNumber == 0)
                {
                    OutputMutuallySimpleNumbers();
                    NOD = secondNumber;
                    return NOD;
                }
                else
                {
                    firstNumber %= secondNumber;
                    return GreatestCommonDivisorEvclidAlgorithm(firstNumber, secondNumber);
                }
            }
            else
            {
                if (secondNumber % firstNumber == 0)
                {
                    OutputMutuallySimpleNumbers();
                    NOD = firstNumber;
                    return NOD;
                }
                else
                {
                    secondNumber %= firstNumber;
                    return GreatestCommonDivisorEvclidAlgorithm(firstNumber, secondNumber);
                }
            }

        }

        // вывод на экран решение задачи на определение являются ли два числа взаимнопростыми
        static void OutputMutuallySimpleNumbers()
        {
            if (naturalNumberFlag == true)
            {
                WorkWithTheConsole.OutputError("Number 0 it is not natural, therefore it can not be coprime with any number\number");
            }
            else if (NOD == 1)
            {
                WorkWithTheConsole.OutputVerity("Numbers " + firstNumber + " and " + secondNumber + " are mutually simple, because their NOD = 1 \number");
            }
            else
            {
                WorkWithTheConsole.OutputError("Numbers " + firstNumber + " and " + secondNumber + " are not mutually simple, because their NOD != 1 \number");
            }
        }


        /// <summary>
        /// TASK: найти совершенные числа на отрезке
        /// </summary>        
        static public void RunPerfectNumbersOnALine()
        {
            WorkWithTheConsole.OutputTitle("Найти совершенные числа на отрезке");
            InputStartAndEndSegment();
            PerfectNumberToFind(startLine, finishLine);
        }

        static int startLine;
        static int finishLine;
        static string perfectNumber = "";

        // ввод начала и конца отрезка, в котором требуется найти совершенные числа
        static void InputStartAndEndSegment()
        {
            WorkWithTheConsole.InputInt32("Enter start and end of the line\number Enter start line: ", ref startLine);
            WorkWithTheConsole.InputInt32("Enter end line:", ref finishLine);
        }

        // алгоритм поиска совершенных чисел
        internal static string PerfectNumberToFind(int startLine, int finishLine)
        {
            perfectNumber = "";
            int number;
            int summa;
            bool flag = false;            
            StringTasks.SwapIntAndInt(ref startLine, ref finishLine);
            for (number = startLine; number < finishLine; number++)
                {
                    summa = 0;
                    if (number % 2 == 0)
                    {
                        for (int index = 1; index <= number / 2; index++)
                        {
                            if (number % index == 0)
                            {
                                summa = summa + index;
                                if (index == number / 2 && number == summa)
                                {
                                    perfectNumber += " " + number;
                                    flag = true;
                                }
                            }
                        }
                    }
                    else continue;
                }
                OutputPerfectNumbers(perfectNumber, flag);
                if (flag) return "Perfect number: " + perfectNumber;
                else return "No perfect numbers";
                        
        }

        // вывод на экран решение задачи по поиску совершенных чисел на отрезке
        static void OutputPerfectNumbers(string perfectNumber, bool flag)
        {

            if (flag)
                WorkWithTheConsole.Output("Perfect number:", perfectNumber);
            else
                WorkWithTheConsole.OutputError("No perfect numbers");
        }

        /// <summary>
        /// TASK: перевод из десятиричной системы исчисления в двоичную
        /// </summary>
        static public void RunTranslationOfNumberSystems()
        {
            WorkWithTheConsole.OutputTitle("Перевод из десятиричной системы исчисления в двоичную");
            InputNumberInDecimalSystem();
            TranslationFromDecimalSystemToBinary(numberDecimalSystem);    
        }

        static int numberDecimalSystem;
        static string numberBinarySystem = "";
        static string remainderDivision = "";

        // ввод числа в десятиричной системе
        static public void InputNumberInDecimalSystem()
        {
            WorkWithTheConsole.InputInt32("Enter a number in a 10-digit number system: ",ref numberDecimalSystem);
        }

        // перевод из десятиричной системы в двоичную
       internal static string TranslationFromDecimalSystemToBinary(int numberDecimalSystem)
        {
            int numberDecimal = numberDecimalSystem;
            numberBinarySystem = "";
            remainderDivision = "";
            bool flagBool = false;
            if (numberDecimalSystem < 0)
            {
                numberDecimalSystem = Math.Abs(numberDecimalSystem);
                flagBool = true;
            }
            do
            {
                remainderDivision += Convert.ToString(numberDecimalSystem % 2);
                numberDecimalSystem /= 2;
            }
            while ((numberDecimalSystem / 2) >= 1);
            remainderDivision += numberDecimalSystem;

            for (int i = remainderDivision.Length - 1; i >= 0; i--)
            {
                numberBinarySystem += remainderDivision[i];
            }
            if (flagBool) numberBinarySystem = "-" + numberBinarySystem;
            if (numberBinarySystem == "00" || numberBinarySystem == "01")
                numberBinarySystem = numberBinarySystem[1].ToString();
            OutputTranslationFromDecimalSystemToBinary(numberDecimal, numberBinarySystem);
            return numberBinarySystem;
        }

        // вывод на экран решение задачи по переводу числа из десятиричной системы в двоичную
        static void OutputTranslationFromDecimalSystemToBinary(int numberDecimalSystem, string numberBinarySystem)
        {
            WorkWithTheConsole.Output("Number " + numberDecimalSystem + " in 2-digit number system = " + numberBinarySystem + "\number");
        }

        /// <summary>
        /// TASK: Определить можно ли представить N! в виде произведения трех последовательных простых чисел
        /// </summary> 
       public static void RunFactorialNumbersAsTheProductOfThreeConsecutivePrimes()
        {
            WorkWithTheConsole.OutputTitle("Ввести натуральное число N. Определить можно ли представить N! в виде произведения трех последовательных простых чисел");
            InputNaturalNumber();
            FactorialNumbersAsTheProductOfThreeConsecutivePrimes(numberN);
        }

        static int numberN;
        static string multiplication3PrimeNumber = "";

        //ввод натурального числа
        static void InputNaturalNumber()
        {            
            WorkWithTheConsole.InputInt32("Enter natural number: ", ref numberN);
            if (numberN <= 0)
            {
                WorkWithTheConsole.OutputError("This is not a natural number \n");
                WorkWithTheConsole.InputInt32("Enter natural number: ", ref numberN);
            }
        }

        // нахождение факториала числа
       internal static long Factorial(int number)
        {
            long factorial = 1;
            if (number < 0) factorial = 0;           
            for(int i=2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // проверка на принадлежность к простым числам    
        internal static bool PrimeNumberCheck(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                {
                        return false;
                }
            //знак "<" поставлен для проверки правильности метода FactorialNumbersAsTheProductOfThreeConsecutivePrimes, надо знак "<="
          //  if (number == 1)
         //     return  false;
            if (number < 1) 
                return false;
            else
                return true;
        }

            // Определить можно ли представить N! в виде произведения трех последовательных простых чисел
        internal static string FactorialNumbersAsTheProductOfThreeConsecutivePrimes(int number)
        {
            int[] array3PrimeNumber = new int[Factorial(number)/2 +1];
           
            bool flag = false;
            int j = 0;
            for (int i = 1; i < array3PrimeNumber.Length; i++)
            {                
                array3PrimeNumber[i] = -1;
                if (PrimeNumberCheck(i))
                {
                    array3PrimeNumber[j] = i;
                    j++;
                }                   
            }

            for(int i = 0; i< array3PrimeNumber.Length - 2; i++)
            {
                if(array3PrimeNumber[i] != -1 && array3PrimeNumber[i+1] != -1 && array3PrimeNumber[i+2] != -1)
                if (Factorial(number) == (array3PrimeNumber[i] * array3PrimeNumber[i + 1] * array3PrimeNumber[i + 2]))
                {
                    multiplication3PrimeNumber += array3PrimeNumber[i] + " * " + array3PrimeNumber[i + 1] + " * " + array3PrimeNumber[i + 2];
                    flag = true;
                }
            }

            if (flag)
            {
                OutputFactorialNumbersAsTheProductOfThreeConsecutivePrimes(true);
                return multiplication3PrimeNumber;
            }
            else
            {
                OutputFactorialNumbersAsTheProductOfThreeConsecutivePrimes(false);
                return "can not imagine " + number + "! = " + Factorial(number) + " as a product of three consecutive prime numbers";
            }     
        }

        static void OutputFactorialNumbersAsTheProductOfThreeConsecutivePrimes(bool flag)
        {
            if (flag)
                WorkWithTheConsole.Output(numberN + "! = " + Factorial(numberN) + ": " + multiplication3PrimeNumber);
            else WorkWithTheConsole.OutputError("can not imagine " + numberN + "! = " + Factorial(numberN) + " as a product of three consecutive prime numbers");            
        }
    }
}
