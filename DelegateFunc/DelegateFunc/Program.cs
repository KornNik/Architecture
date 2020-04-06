using System;
using System.Collections.Generic;

namespace DelegateFunc
{

    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;
        static Func<string, string, int, string> func;

        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void Run()
        {
            var steps = GetActionSteps();
            func = (name, description, age) => string.Format(Format, name, description, Address, age);
            foreach (var items in steps) { items(); }
        }

        private static List<Action> GetActionSteps()
        {
            return new List<Action>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore

            };

        }
        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(func(name, description, age));
        }
        static void Main(string[] args)
        {
            Run();

        }
    }
}
