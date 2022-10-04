using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2
{
    public class Rectangle
    {
        private int Length { get; set; }
        private int Width { get; set; }
        public Rectangle() // Default Constructor
        {

            Length = 1;
            Width = 1;
        }
        public Rectangle(int length, int width) // Non-Default Constructor
        {
            Length = length;
            Width = width;
        }
        public int GetCurrentLength()
        {
            return Length;
        }

        public int SetNewLength(int length)
        {
            Length = length;
            return Length;
        }
        public int GetCurrentWidth()
        {
            return Width;
        }
        public int SetNewWidth(int width)
        {
            Width = width;
            return Width;
        }
        public int GetPerimeter()
        {
            int halfPerimeter = Length + Width;
            return halfPerimeter * 2;
        }
        public int GetArea()
        {
            int area = Length * Width;
            return area;
        }

    }


}
