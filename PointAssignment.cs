using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal struct PointAssignment
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public PointAssignment(int x, int y)
        {
            X = x; Y = y;
        }
    }
}
