using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal struct point
    {
        public int x;
        public int y;
        public point()
        {
            x = 0; y = 0;
        }
        public point(int _x, int _y) { 
            this.x = _x; this.y = _y;
        }
        public override string ToString()
        {
            return $"x = {x} , y = {y}";
        }
    }
}
