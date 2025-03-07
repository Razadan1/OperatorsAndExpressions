using System;

namespace OperatorsAndExpressions
{
    public class Exercise2
    {
        // 2. Write a Boolean expression that checks whether a given integer is 
            // divisible by both 5 and 7, without a remainder. 
        public void SolveExercise2()
        {
            int a = 35;

            bool h = a % 5 == 0 && a % 7 == 0;
            Console.WriteLine($"{h}");
        }
    }
}