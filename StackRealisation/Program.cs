using System;
using System.Collections.Generic;

namespace StackRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stackkk stack = new Stackkk();
            
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
