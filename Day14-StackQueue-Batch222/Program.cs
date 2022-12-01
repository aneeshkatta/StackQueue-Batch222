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
            Console.WriteLine("Queue Elements are:");
            LinkedListQueue QueueOperationobj = new LinkedListQueue();
            QueueOperationobj.Enqueue(56);
            QueueOperationobj.Enqueue(30);
            QueueOperationobj.Enqueue(70);
            QueueOperationobj.Display();
            QueueOperationobj.Dequeue(56);
            QueueOperationobj.Dequeue(30);
            QueueOperationobj.Dequeue(70);
            QueueOperationobj.Display();
            Console.ReadKey();
        }
    }
}
