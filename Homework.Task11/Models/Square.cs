using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Task11.Models
{
    internal class Square : Figure
    {
        internal int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }
        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}