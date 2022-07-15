using System;

namespace MyMaths
{
    public class Oprations
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Add()
        {
            Console.WriteLine($"The addition of the {this.x} and {this.y} is {this.x + this.y}.");
        }

        public void Multiply()
        {
            Console.WriteLine($"The multiplication of the {this.x} and {this.y} is {this.x * this.y}.");
        }
    }
}
