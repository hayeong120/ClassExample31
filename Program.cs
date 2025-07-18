﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }

            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(double param) { Console.WriteLine("Parent(double param)"); }
        }

        class Child : Parent
        {
            public new string variable = "하이딩";

            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }


            public void CountChild()
            {
                Child.counter++;
            }

            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name)       // 부모의 기본 생성자가 호출
            {
                Console.WriteLine("Child(string name)");
            }

            public Child(double param) : base(param)
            {
                Console.WriteLine("Child(double param)");
            }
        }

        public static int number = 20;

        static void Main(string[] args)
        {
            // 섀도잉
            int number = 10;
            Console.WriteLine(number);      // 클래스 변수 이름이 가려짐 (shadowing)
            Console.WriteLine(Program.number);  // 호출하고 싶으면 클래스 변수명 사용


            Child child = new Child();  // 부모생성자부터 호출
            Child child1 = new Child(3);    // int -> double로 자동 형변환, long도 변환됨

            Parent p = new Parent();
            Child child2 = new Child();

            // 클래스 변수는 상속관계에서 서로 공유함
            p.CountParent();
            child2.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

            // 변수 하이딩
            Child child3 = new Child();
            Console.WriteLine(child3.variable);     // 문자열 variable 출력
            Console.WriteLine(((Parent)child3).variable);   // 숫자 variable 출력

            // 메서드 하이딩
            //child3.Method();    // 자식 메서드 출력
            //((Parent)child3).Method();  // 부모 메서드 출력

            // 메서드 오버라이딩
            //child3.Method();    // 자식 메서드 출력
            //((Parent)child3).Method();  // 부모 메서드 출력

            // 메서드 하이딩, 오버라이딩 비교 구현
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Cat(), new Dog()
            };

            foreach(var item in Animals)
            {
                item.Eat();
            }
        }
    }
}