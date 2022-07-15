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

            Oprations op = new Oprations();
            op.x = 12;
            op.y = 45;
            op.Add();
            op.Multiply();

            Console.WriteLine("Exiting from application...............");
            Console.ReadLine();

        }
    }
}
