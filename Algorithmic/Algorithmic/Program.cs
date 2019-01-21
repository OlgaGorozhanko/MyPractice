using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("AlgorithmicTests")]

namespace Algorithmic
{
    class Program
    {        
        static void Main(string[] args)
        {
            //  DifferentTasks.RunMutuallySimpleNumber();
            //  DifferentTasks.RunPerfectNumbersOnALine();
            //  ArraysTasks.RunSummaTwoSmallestAndTwoLargestElementArray();
            //  DifferentTasks.RunTranslationOfNumberSystems();
            Console.WriteLine("int от * = {0}",(int)'*');
            StringTasks.RunSortText();
            ArraysTasks.RunMaximumDoesNotDecreaseSequence();
        }
    }
}
