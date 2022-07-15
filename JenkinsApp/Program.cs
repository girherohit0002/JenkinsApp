using System;
using MyMaths;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");

            Console.WriteLine("This is changing I am doing in order to whether it is running or not");

            Oprations op = new Oprations () { };
            op.x = 12;
            op.y = 45;
            Console.WriteLine($"Addition is {op.Add(op.x,op.y)} and Multiplication is {op.Multiply(op.x, op.y)}");

            Console.WriteLine("Exiting from application...............");
            Console.ReadLine();

        }
    }
}
