using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample31
{
    static class Program
    {
        class Parent
        {
            public void CountParent()
            {
                Parent.counter++;
            }
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }

            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(double param) { Console.WriteLine("Parent(int double)"); }
        }

        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }
            public Child(int param) : base(param)
            {
                Console.WriteLine("Child(double parsm)");
            }
        }

        public static int number = 10;
        

        static void Main(string[] args)
        {
            // 섀도잉
            int number = 20;
            Console.WriteLine(number);      // 클래스 변수 이름이 가져림
            Console.WriteLine(Program.number);      // 호출하고 싶으면 클래스 변수명으로 사용

            Child childA = new Child("abc");
            Child childB = new Child(3L);

            childA.CountParent();
            childB.CountChild();
        }
    }
}
