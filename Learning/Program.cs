using System;

namespace Learning
{
    internal class Program
    {
        public delegate void Callback1(int a, int b);
        public delegate void Callback2(string);
        static void Main(string[] args)
        {
            Callback1 handler1 = DelegateMethod;
            Callback2 handler2 = DelegateMethod;

            // Call the delegate.
            handler1(1, 2);
            handler2("saif");

            Console.ReadLine();
        }
        public static void DelegateMethod(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void DelegateMethod(string print)
        {
            Console.WriteLine(print);
        }
        public static void MethodWithCallback(int param1, int param2, Callback1 callback)
        {
            callback(1, 2);
        }
    }
}
