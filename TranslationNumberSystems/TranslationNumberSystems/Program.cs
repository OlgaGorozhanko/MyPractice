using System;
using System.Text;

namespace TranslationSystemsCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberSystemsCalculation.Input();
            NumberSystemsCalculation.CalculationFrom_10_to_2(NumberSystemsCalculation.number_system10);
            NumberSystemsCalculation.Output(NumberSystemsCalculation.number_system10, NumberSystemsCalculation.number_system2);
            Console.ReadKey();
        }
    }

    // translation of number systems 
    class NumberSystemsCalculation
    {
        static public int number_system10;
        static public string number_system2="";
        static string remainder_division ="";


        static public void Input()
        {
            Console.Write("Enter a number in a 10-digit number system: ");
            number_system10 = Convert.ToInt32(Console.ReadLine());
        }

        static public void CalculationFrom_10_to_2(int number_system10)
        {
            do
            {
                remainder_division += Convert.ToString(number_system10 % 2);
                number_system10 /= 2;
            }
            while ((number_system10 / 2) >= 1);
            remainder_division += number_system10;            
                       
            for (int i= remainder_division.Length-1; i>=0; i--)
            {               
                number_system2 += remainder_division[i];                
            }

            
        }

        static public void Output(int number_system10, string number_system2)
        {
            Console.WriteLine("Number {0} in 2-digit number system = {1}", number_system10, number_system2);
        }
    }
}
