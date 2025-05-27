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


        // 고전적인 스타일
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


        // 자바
        public int getWidth() { return this.width; }
        public int getHeight() { return this.height; }

        public void setWidth(int width)
        {
            if(width>0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로 입력해주세요"); }
        }

        public void setHeight(int height)
        {
            if (width > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수로 입력해주세요"); }
        }

        public int Area()
        {
            return this.width = this.height;
        }

    } // Class Box
}
