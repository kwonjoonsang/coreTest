using System;

namespace coreTest.CStudy
{
    interface ICar
    {
        void Go();
    }

    class Car : ICar
    {
        public void Go() => Console.WriteLine("Power Instance");
    }

    public class InterfaceNote
    {
        static void Main()
        {
            var car = new Car();
            car.Go();
        }
    }
}