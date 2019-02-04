using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic
{
    /// <summary>
    /// КЛАСС ДЛЯ РАБОТЫ С КОНСОЛЬЮ
    /// </summary>
    class WorkWithTheConsole
    {
        // вывод на экран темы
        static internal string OutputTitle(string textTitle)
        {
            WorkWithTheConsole.Output("\n\t\tTASK: " + textTitle + "\n");
            return "\n\t\tTASK: " + textTitle + "\n";
        }

        // вывод на экран решения (нельзя тестировать: работа с консолью)
        static public void Output(string text, string textValue)
        {
            Console.WriteLine(text + "{0}", textValue);
        }

        // вывод на экран решения (нельзя тестировать: работа с консолью)
        static public void Output(string text, int intValue)
        {
            Console.WriteLine(text + "{0}", intValue.ToString());
        }

        // вывод на экран сообщения (нельзя тестировать: работа с консолью)
        static public void Output(string text)
        {
            Console.Write(text);
        }

        // вывод на экран число (нельзя тестировать: работа с консолью)
        static public void Output(int intValue)
        {
            Console.Write(intValue);
        }

        // вывод на экран сообщения об ошибке
        static public void OutputError(string textError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Output(" " + textError);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // вывод на экран сообщения о правильности
        static public void OutputVerity(string textVerity)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Output(" " + textVerity);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // ввод значения типа Int32 (для программы)
        static public void InputInt32(string text, ref int intValue)
        {
            try
            {
                Output(text);
                intValue = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                OutputError("DATA TYPE ERROR. Enter a number\n");
                InputInt32(text, ref intValue);
            }
            catch (Exception)
            {
                OutputError("ERROR\n");
                InputInt32(text, ref intValue);
            }
        }

        // ввод значения типа Int32 (для тестов)
        static internal string InputInt32Tests( ref object intValue)
        {
            try
            {
                intValue = Convert.ToInt32(intValue);
                return intValue.ToString();
            }
            catch (FormatException)
            {
                OutputError("DATA TYPE ERROR. Enter a number");
                return "DATA TYPE ERROR. Enter a number";
            }
            catch (Exception)
            {
                OutputError("ERROR");
                return "ERROR";
            }
        }

        // ввод значения типа String
        static public void InputString(string text, ref string stringValue)
        {
            try
            {
                Output(text);
                stringValue = Console.ReadLine();
            }
            catch (FormatException)
            {
                OutputError("DATA TYPE ERROR");
                InputString(text, ref stringValue);
            }
            catch (Exception)
            {
                OutputError("ERROR");
                InputString(text, ref stringValue);
            }
        }

        static public void ScreenDelay()
        {
            Console.ReadKey();
        }
    }
}
