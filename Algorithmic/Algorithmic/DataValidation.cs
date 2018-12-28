using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmic
{
    class DataValidation
    {
       /* // проверка на корректность ввода целых чисел
        static public void InputValidationInt32(ref int number, string textConsole)
        {
            try
            {
                WorkWithTheConsole.Output(textConsole);
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                WorkWithTheConsole.OutputError("DATA TYPE ERROR. Enter a number");
                InputValidationInt32(ref number, textConsole);
            }
        }
*/       

        // проверка на ввод натуральных чисел
        static public void InputValidationNaturalNumber(ref int number, string textConsole)
        {
            int naturalNumber;
            try
            {
                WorkWithTheConsole.Output(textConsole);
                naturalNumber = Convert.ToInt32(Console.ReadLine());
                if (naturalNumber <= 0)
                {
                    WorkWithTheConsole.OutputError("ERROR. Input natural number\n");
                    InputValidationNaturalNumber(ref number, textConsole);
                }
                else number = naturalNumber;
            }
            catch (Exception)
            {
                WorkWithTheConsole.OutputError("DATA TYPE ERROR. Enter a number\n");
                InputValidationNaturalNumber(ref number, textConsole);
            }
        }
    }
}
