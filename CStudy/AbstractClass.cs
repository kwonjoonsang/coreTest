namespace coreTest.CStudy
{
    public class AbstractClass
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Square : Shape
        {
            private int _size;

            public Square(int size)
            {
                _size = size;
            }

            public override double GetArea()
            {
                return _size * _size;
            }
        }

        static void Main()
        {
            Square square = new Square(10);
            square.GetArea();
        }
    }
}