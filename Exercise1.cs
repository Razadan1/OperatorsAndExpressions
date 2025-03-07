using System;

namespace OperatorsAndExpressions
{
    public class Exercise1
    {
        public void solveExercise1()
        {
            // 1. Write an expression that checks whether an integer is odd or even. 
            int n = 12;
            int  m = n % 2;
            Console.WriteLine($"Let's check if {n} is odd or even\n {n} % 2 = {m}\n Yaay, it is even");
        }
    }
}