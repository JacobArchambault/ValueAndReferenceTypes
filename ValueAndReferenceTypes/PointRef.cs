using static System.Console;

namespace ValueAndReferenceTypes
{
    // Classes are always reference types.
    class PointRef
    {
        public int X;
        public int Y;

        // A custom constructor.
        public PointRef(int XPos, int YPos)
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
}
