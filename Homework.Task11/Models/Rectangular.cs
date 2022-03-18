using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Task11.Models
{
    internal class Rectangular : Figure
    {
        internal int Width { get; set; }
        internal int Length { get; set; }

        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int CalcArea()
        {
            return Width * Length;
        }
    }
}
