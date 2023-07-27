using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("AMan");
            stack.Push("Vijay");
            stack.Push("ZOya");
            stack.Push("Raj");
            stack.Push("Kiran");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("number of itmes in stacks are:\t" + stack.Count);
            Console.WriteLine("_____________________________________________________________");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("number of itmes in stacks are:\t" + stack.Count);
            Console.WriteLine("_____________________________________________________________");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Example of peek\t" + stack.Peek());
            Console.WriteLine("After peek");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("number of itmes in stacks are:\t" + stack.Count);
            Console.WriteLine("_____________________________________________________________");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Clear();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("after using clear number of itmes in stacks are:\t" + stack.Count);
            Console.WriteLine("_____________________________________________________________");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}