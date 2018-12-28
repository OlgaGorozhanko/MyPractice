using System;

namespace Algorithmic
{
    class StringTask
    {
        /// <summary>
        /// TASK: сортировка по алфавиту
        /// </summary>
        static public void RunSortText()
        {
            WorkWithTheConsole.OutputTitle("Сортировать буквы в строке по алфавиту");
            InputString();
            SortAlphabet(stringEntered);
            WorkWithTheConsole.ScreenDelay();
        }

        static string stringEntered;

        /// <summary>
        /// ввод строки
        /// </summary>
        static void InputString()
        {
            WorkWithTheConsole.InputString("Enter string: ", ref stringEntered);
            if (stringEntered == "")
            {
                    WorkWithTheConsole.Output("You did not enter a string.");
                    InputString();
            }          
        }

        static void SortAlphabet(string stringInput)
        {
            char[] stringResult = new char[stringInput.Length];
            ArrayOfCharactersFromString(stringInput, ref stringResult);
            double letterCode1 = 0;
            double letterCode2 = 0;

            for (int i = 0; i < stringInput.Length; i++)
            {
                for (int j = i + 1; j < stringInput.Length; j++)
                {
                    letterCode1 = 0;
                    letterCode2 = 0;
                    SmallLettersInLarge(stringResult[i], ref letterCode1);
                    SmallLettersInLarge(stringResult[j], ref letterCode2);
                    Swap(letterCode2, letterCode1, ref stringResult[i], ref stringResult[j]);
                }
            }
            WorkWithTheConsole.Output("Start string:", stringInput);
            WorkWithTheConsole.Output("Result string:");
            for (int i = 0; i < stringInput.Length; i++)
                WorkWithTheConsole.Output(stringResult[i].ToString());
            WorkWithTheConsole.Output("\n");
        }

        // изменение кода маленькой буквы на -31.5 (разница в коде между большими и маленькими буквами в кодировке)
        static void SmallLettersInLarge(char letter, ref double letterCode)
        {
            if (((int)letter > 96 && (int)letter < 123) ||
                       (int)letter > 1071 && (int)letter < 1104)
                letterCode = (int)letter - 31.5;
            else letterCode = (int)letter;
        }

        // символьный массив из строки
        static public void ArrayOfCharactersFromString(string textString, ref char[] arrayChar)
        {
            for (int i = 0; i < textString.Length; i++)
            {
                arrayChar[i] = textString[i];
            }
        }

        // метод для обмена элементами
        static public void Swap(double numberLess, double numberLarger, ref char char1, ref char char2)
        {
            char swap = ' ';
            if (numberLarger > numberLess)
            {
                swap = char1;
                char1 = char2;
                char2 = swap;
            }
        }
        
    }
}
