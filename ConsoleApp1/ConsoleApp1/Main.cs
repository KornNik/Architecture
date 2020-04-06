using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());
            Customer customer = new Customer(new DefaultIdGenerator());

            Console.WriteLine(store.Id);
            Console.WriteLine();
            Console.WriteLine($"{customer.Id}, {customer.Description}");
        }
    }
}