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
            public Parent() { Console.WriteLine("부모 생성자"); }
        }

        public class Child : Parent
        {
            public Child()
            {
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
        }
    }
}
