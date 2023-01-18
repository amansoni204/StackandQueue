using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue2022
{
    internal class LinkedListStack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the stack element");
            LinkedListStack stacklist = new LinkedListStack();
            stacklist.Push(70);
            stacklist.Push(30);
            stacklist.Push(56);
            stacklist.Display();
            Console.ReadLine();
        }
    }
}
