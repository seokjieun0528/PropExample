using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        private int width;
        private int height;

        public Box(int w, int h)
        {
            if(width > 0 && height > 0)
            {
                this.width = w;
                this.height = h;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연스로 초기화해주세요");
                //throw new Exception("너비와 높이는 자연스로 초기화해주세요");
            }
        }   // Box

        public int Area()
        {
            return this.width = this.height;
        }

    } // Class Box
}
