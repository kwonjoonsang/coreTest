using System;

namespace coreTest.CStudy
{
    public class BaseKeyword
    {
        public class Car
        {
            private string name;

            public Car(string name)
            {
                this.name = name;
            }

            public void Run() => Console.WriteLine($"{this.name}가 달린다.");
        }
    }

    public class My : Car
    {
        public My() : this("My Car")
        {
        }

        public My(string name) : base(name)
        {
        }
    }

    public class Your : Car
    {
        public Your() : base("Your Car")
        {
        }
    }

class BaseKeyword
    {
        static void Main()
        {
            (new My()).Run();
            (new My("My Good Car")).Run();
            new Your().Run();
        }
    }
}