using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackQueue_Batch222
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Stack Elements:");
            LinkedListStack StackOperation = new LinkedListStack();
            StackOperation.Push(70);
            StackOperation.Push(30);
            StackOperation.Push(56);
            StackOperation.Display();
            StackOperation.Peek();
            StackOperation.Pop();
            StackOperation.IsEmpty();
            StackOperation.Display();
            Console.ReadKey();
        }
    }
}
