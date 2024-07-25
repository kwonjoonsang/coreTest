using System;

namespace coreTest.CStudy
{
    public class ConstructorBase
    {
        class Parent
        {
            public Parent(string message) => Console.WriteLine(message);
        }

        class Child : Parent
        {
            public Child(string message) : base(message)
            {
            }
        }

        class ConstructorBase
        {
            static void Main()
            {
                string message = "Child Class Constructor -> Parent Class Constructor";
                var child = new Child(message);
            }
        }
    }
}