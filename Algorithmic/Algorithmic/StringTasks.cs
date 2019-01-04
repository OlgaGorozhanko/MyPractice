
namespace Algorithmic
{
    class StringTasks
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

        internal static char[] SortAlphabet(string stringInput)
        {
            char[] stringResult = new char[stringInput.Length];
            ArrayOfCharactersFromString(stringInput, ref stringResult);   
            for (int i = 0; i < stringInput.Length; i++)
            {
                for (int j = i + 1; j < stringInput.Length; j++)
                {
                    Swap(SmallLettersInLarge(stringResult[i]), SmallLettersInLarge(stringResult[j]), ref stringResult[i], ref stringResult[j]);
                }
            }
            WorkWithTheConsole.Output("Start string:", stringInput);
            WorkWithTheConsole.Output("Result string:");
            for (int i = 0; i < stringInput.Length; i++)
                WorkWithTheConsole.Output(stringResult[i].ToString());
            WorkWithTheConsole.Output("\n");
            return stringResult;
        }

        // изменение кода маленькой буквы на -31.5 (разница в коде между большими и маленькими буквами в кодировке)
       internal static double SmallLettersInLarge(char letter)
        {
            double letterCode = 0;
            if (((int)letter > 96 && (int)letter < 123) ||
                       (int)letter > 1071 && (int)letter < 1104)
                letterCode = (int)letter - 31.5;
            else letterCode = (int)letter;
            return letterCode;
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
        static public char[] Swap(double numberLess, double numberLarger, ref char charLess, ref char charLarger)
        {
            char[] arrayCharSwap = new char[2];
            char swap = ' ';
            if (numberLess > numberLarger)
            {
                swap = charLess;
                charLess = charLarger;
                charLarger = swap;                
            }
            arrayCharSwap[0] = charLess;
            arrayCharSwap[1] = charLarger;
            return arrayCharSwap;
        }
    }
}
