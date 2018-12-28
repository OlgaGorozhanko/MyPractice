using System;

/// <summary>
/// rus: различные задачи на алгоритмику
/// </summary>
namespace Algorithmic
{
    class DifferentTasks
    {
        /// <summary>
        /// TASK: определить являются ли целые числа взаимпнопростыми
        /// </summary> 
        static public void RunMutuallySimpleNumber()
        {
            WorkWithTheConsole.OutputTitle("Определить являются ли целые числа взаимпнопростыми");
            InputWholeNumbers();
            GreatestCommonDivisorEvclidAlgorithm(firstNumber, secondNumber);
            OutputMutuallySimpleNumbers();
            WorkWithTheConsole.ScreenDelay();
        }

        static public int firstNumber;
        static public int secondNumber;
        static bool naturalNumberFlag = false;
       

        // ввод двух целых чисел
        static void InputWholeNumbers()
        {
           WorkWithTheConsole.InputInt32("Enter 2 whole numbers\n 1st number = ", ref firstNumber);
            WorkWithTheConsole.InputInt32(" 2st number = ", ref secondNumber);
        }

        // модуль натурального числа
        static void NaturalNumber(ref int number, ref bool naturalNumberFlag)
        {
            number = Math.Abs(number);
            if (number == 0)
            {
                naturalNumberFlag = true;
            }
        }

        // алгоритм поиска НОД (Наибольший общий делитель)
        static double GreatestCommonDivisorEvclidAlgorithm(int firstNumber, int secondNumber)
        {
            NaturalNumber(ref firstNumber, ref naturalNumberFlag);
            NaturalNumber(ref secondNumber, ref naturalNumberFlag);
            if (naturalNumberFlag == true) { return 0; }
            else if (firstNumber > secondNumber)
            {
                if (firstNumber % secondNumber == 0) return secondNumber;
                else
                {
                    firstNumber %= secondNumber;
                    return GreatestCommonDivisorEvclidAlgorithm(firstNumber, secondNumber);
                }
            }
            else
            {
                if (secondNumber % firstNumber == 0) return firstNumber;
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
                WorkWithTheConsole.OutputError("Number 0 it is not natural, therefore it can not be coprime with any number\n");
            }
             else   if (GreatestCommonDivisorEvclidAlgorithm(firstNumber, secondNumber) == 1)
            {
                WorkWithTheConsole.OutputVerity("Numbers " + firstNumber + " and "+ secondNumber + " are mutually simple, because their NOD = 1 \n");
            }
            else
            {
                WorkWithTheConsole.OutputError("Numbers " + firstNumber + " and " + secondNumber + " are not mutually simple, because their NOD != 1 \n");
            }
        }


        /// <summary>
        /// TASK: найти совершенные числа на отрезке
        /// </summary>        
        static public void RunPerfectNumbersOnALine()
        {
            WorkWithTheConsole.OutputTitle("Найти совершенные числа на отрезке");
            InputStartAndEndSegment();
            PerfectNumberToFind();
            WorkWithTheConsole.ScreenDelay();
        }

        static int startLine;
        static int finishLine;
        static string perfectNumber = "";

        // ввод начала и конца отрезка, в котором требуется найти совершенные числа
        static void InputStartAndEndSegment()
        {
            WorkWithTheConsole.InputInt32("Enter start and end of the line\n Enter start line: ", ref startLine);
            WorkWithTheConsole.InputInt32("Enter end line:", ref finishLine);
        }

        // алгоритм поиска совершенных чисел
        static void PerfectNumberToFind()
        {
            int number;
            int summa;
            bool flag = false;       
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
                            if (index == number/2 && number == summa)
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
        }

        // вывод на экран решение задачи по поиску совершенных чисел на отрезке
        static void OutputPerfectNumbers(string perfectNumber, bool flag)
        {

            if (flag)
                WorkWithTheConsole.Output("Perfect number: ", perfectNumber);            
            else            
                WorkWithTheConsole.OutputError("No perfect numbers");
            WorkWithTheConsole.Output("\n");
        }

        /// <summary>
        /// TASK: перевод из десятиричной системы исчисления в двоичную
        /// </summary>
        static public void RunTranslationOfNumberSystems()
        {
            WorkWithTheConsole.OutputTitle("Перевод из десятиричной системы исчисления в двоичную");
            InputNumberInDecimalSystem();
            TranslationFromDecimalSystemToBinary(numberDecimalSystem);
            OutputTranslationFromDecimalSystemToBinary(numberDecimalSystem, numberBinarySystem);
            WorkWithTheConsole.ScreenDelay();
        }

        static int numberDecimalSystem;
        static string numberBinarySystem = "";
        static string remainderDivision = "";
          
        // ввод числа в десятиричной системе
        static public void InputNumberInDecimalSystem()
        {
           DataValidation.InputValidationNaturalNumber(ref numberDecimalSystem, "Enter a number in a 10-digit number system: ");
        }

        // перевод из десятиричной системы в двоичную
        static void TranslationFromDecimalSystemToBinary(int numberDecimalSystem)
        {
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
        }

        // вывод на экран решение задачи по переводу числа из десятиричной системы в двоичную
        static void OutputTranslationFromDecimalSystemToBinary(int numberDecimalSystem, string numberBinarySystem)
        {
            WorkWithTheConsole.Output("Number "+ numberDecimalSystem + " in 2-digit number system = "+ numberBinarySystem + "\n");
        }

    }   
}



