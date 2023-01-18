using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue2022
{
    internal class LinkedListQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Elements are:");
            LinkedListQueue QueueOperation = new LinkedListQueue();
            QueueOperation.Enqueue(56);
            QueueOperation.Enqueue(30);
            QueueOperation.Enqueue(70);
            QueueOperation.Display();
            Console.ReadLine();
        }
    }
}
