using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("AlgorithmicTests")]

namespace Algorithmic
{
    class Program
    {        
        static void Main(string[] args)
        {
            DifferentTasks.RunMutuallySimpleNumber();
            DifferentTasks.RunPerfectNumbersOnALine();
            ArraysTasks.RunSummaTwoSmallestAndTwoLargestElementArray();
            DifferentTasks.RunTranslationOfNumberSystems();            
            StringTasks.RunSortText();
            ArraysTasks.RunMaximumDoesNotDecreaseSequence();
        }
    }
}
