using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("Selim");
            stack.Push("Ali");
            stack.Push("Vali");
            stack.Push("Alim");
            stack.Push("Alirza");

            stack.Pop();
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count " + stack.Count);
            Console.WriteLine("Capacity " + stack.Capacity);

            Console.WriteLine(stack.Peek());
        }



    }
}
