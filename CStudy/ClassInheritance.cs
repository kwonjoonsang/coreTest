using System;

namespace coreTest.CStudy
{
    public class ClassInheritance
    {
        public class ParentClass : Object
        {
            protected void Print1() => Console.WriteLine("BAse Class Content");
        }

        public class ChildClass : ParentClass
        {
            public void Print2() => base.Print1();
        }

        class ClassInheritance : Object
        {
            static void Main()
            {
                //ClassInheritance Parent Class
                ParentClass p = new ParentClass();
                Console.WriteLine(p.ToString());
                
                //ClassInheritance Child Class
                ChildClass c = new ChildClass();
                c.Print2();
            }
        }
    }
}