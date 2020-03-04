using static System.Console;

namespace ValueAndReferenceTypes
{
    class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            // A custom constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            // Add 1 to the (X, Y) position.
            public void Increment()
            {
                X++; Y++;
            }

            // Subtract 1 from the (X, Y) position.
            public void Decrement()
            {
                X--; Y--;
            }

            // Display the current position.
            public void Display() => WriteLine($"X = {X}, Y = {Y}");
        }

        struct Rectangle
        {
            // The Rectangle structure contains a reference type member.
            public ShapeInfo RectInfo;

            public int RectTop, RectLeft, RectBottom, RectRight;

            public Rectangle(string info, int top, int left, int bottom, int right)
            {
                RectInfo = new ShapeInfo(info);
                RectTop = top;
                RectBottom = bottom;
                RectLeft = left;
                RectRight = right;
            }

            public void Display() => WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}, Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight}");
        }
        static void Main()
        {
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();
            ReadLine();
        }

        // Assigning two intrinsic value types results in two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            WriteLine("Assigning value types \n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // Print both points.
            p1.Display();
            p2.Display();

            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            WriteLine("\n Changed p1.X\n");
            p1.Display();
            p2.Display();
            WriteLine();
        }

        static void ReferenceTypeAssignment()
        {
            WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs.
            p1.Display();
            p2.Display();

            // Change p1.X and print again.
            p1.X = 100;
            WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
            WriteLine();
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle.
            WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1.
            WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            // Print values of both rectangles.
            r1.Display();
            r2.Display();
            WriteLine();
        }
    }
}
