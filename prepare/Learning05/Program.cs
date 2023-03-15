using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Red", 12);

        Square square2 = new Square("Blue", 13);

        Rectangle rec1 = new Rectangle("Red", 12, 6);

        Rectangle rec2 = new Rectangle("Blue", 10, 4);

        Circle circle1 = new Circle("Red", 5);

        Circle circle2 = new Circle("Blue", 7);

        List<Shape> shapes = new List<Shape>(){
            square1,
            square2,
            rec1,
            rec2,
            circle1,
            circle2
        };

        foreach(Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}