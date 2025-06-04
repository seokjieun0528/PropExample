using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        public static int classVar = 0;
        static void Main(string[] args)
        {
            // 클래스 변수 호출
            Program.classVar = -1;

            // 인스턴스 변수처럼 클래스 변수 사용 불가에 주의(자바에서는 가능 해깔리지 않도록 주의)
            //Program p = new Program();
            //p.classVar = -3

            // 기본 생성자 : 생성자를 하나라도 정의하면 기본 생성자를 따로 지정줘야한다
            //Product p = new Product();

            // 팩토리 메서드
            Product p = Product.GetInstance("아아", 1000);

            // 정적 생상자 예제
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

            MyMath m = new MyMath();
            Console.WriteLine(MyMath.PI);

            Item item1 = new Item("고구마", 1000);
            Item item2 = new Item("사과", 1500);
            Item item3 = new Item("감자", 2000);
            Console.WriteLine(item1.id);
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            //Item.id = 3 // readonly 키워드가 지정된 인스턴스 변수는 수정 불가

            Box box1 = new Box(100, 200);
            box1.Width = -3;
            Console.WriteLine(box1.Width);
         
            Console.WriteLine(box1.Area());

            // 값 복사
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a);   // a와 b는 별개변수

            // 참조 복사
            Test test = new Test();
            test.value = 20;
            change(test);
            Console.WriteLine(test.value);

            // 참소 복사 예제 하나 더
            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
            

        }

        class Test
        {
            public int value = 10;
        }

        static void change(Test input)
        {
            input.value = 20;
        }
    }
}
