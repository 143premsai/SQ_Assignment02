using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public int GetCurrentLength()
        {
            return this.length;
        }

        public int SetNewLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetCurrentWidth()
        {
            return this.width;
        }
        public int SetNewWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            int result = 2 * (this.length + this.width);
            return result;
        }
        public int GetArea()
        {
            int result = this.length * this.width;
            return result;
        }
    }
}
