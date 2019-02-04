
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
        }

        static string stringEntered;

        /// <summary>
        /// ввод строки
        /// </summary>
        static void InputString()
        {
            stringEntered = "";
            WorkWithTheConsole.InputString("Enter string: ", ref stringEntered);
            if (stringEntered == "")
            {
                WorkWithTheConsole.OutputError("You did not enter a string.\n");
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
                    SwapCharAndChar(SmallLettersInLarge(stringResult[i]), SmallLettersInLarge(stringResult[j]), ref stringResult[i], ref stringResult[j]);
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

        // метод для обмена элементами (два типа Char)
        static public char[] SwapCharAndChar(double numberLess, double numberLarger, ref char charLess, ref char charLarger)
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

        // метод для обмена элементами (два типа Int32)
        static public int[] SwapIntAndInt(ref int numberLess,ref int numberLarger)
        {
            int[] arrayIntSwap = new int[2];
            int swap = 0;
            if (numberLess > numberLarger)
            {
                swap = numberLess;
                numberLess = numberLarger;
                numberLarger = swap;
            }
            arrayIntSwap[0] = numberLess;
            arrayIntSwap[1] = numberLarger;
            return arrayIntSwap;
        }

        /// <summary>
        /// TASK: Введите строку из N символов. 
        /// В функции определить и вывести на экран частоту встречаемости каждой буквы русского алфавита. 
        /// Определить 5 наиболее часто встречающихся букв. 
        /// Далее, по предоставленному шифру (вы знаете, что каждой букве русского языка соответствует 1 символ в шифре), 
        /// попробовать расшифровать изначальный текст
        /// </summary>
     public static void RunNumberOfRussianLettersPerLine()
        {
            WorkWithTheConsole.OutputTitle("Определить и вывести на экран частоту встречаемости каждой буквы русского алфавита." +
                "Определить 5 наиболее часто встречающихся букв");
            InputString();
        }




    }
}
