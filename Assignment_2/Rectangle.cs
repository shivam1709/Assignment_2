using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Rectangle
    {
        public int GetCurrentLength { get; set; }

        public int SetNewLength(int length){ return 0; }
        public int GetCurrentWidth { get; set; }
        public int SetNewWidth (int width) {return 0; }
        public int GetPerimeter { get; set; }
        public int GetArea { get; set; }

        private int length;
        private int width;
        public Rectangle() // Default Constructor
        {

            length = 1;
            width = 1;
        }
        public  Rectangle(int length, int width) // Non-Default Constructor
        {
            
        }
    }
   

}
