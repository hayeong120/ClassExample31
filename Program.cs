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

        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3L);

            parent.CountParent();
            child.CoumnChild();
            
        }
    }
}
