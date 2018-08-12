using System;
using System.Text;

namespace Alphabet_sorted
{
    class Program
    {
        static void Main(string[] args)
        {

            SortAlhabet.Input();
            SortAlhabet.SortText(SortAlhabet.text);
            Console.ReadKey();
        }
    }

    class SortAlhabet
    {
        static public string text;

        static public void Input()
        {            
            Console.WriteLine("Enter text: ");
            text = Console.ReadLine();            
        }

        static public void SortText(string text)
        {
            char[] ch;
            ch = text.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine(ch);
        }
    }
}
