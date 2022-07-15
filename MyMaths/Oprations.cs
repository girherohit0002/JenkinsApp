using System;

namespace MyMaths
{
    public class Oprations
    {
        public int x { get; set; }
        public int y { get; set; }

        public int Add(int x,int y)
        {
            this.x = x;
            this.y = y;
              return this.x + this.y;
        }

        public int Multiply(int x,int y)
        {
            this.x = x;
            this.y = y;
            return this.x * this.y; 
        }
    }
}
