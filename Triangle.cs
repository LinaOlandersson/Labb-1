namespace Labb_1
{
    internal class Triangle
    {
        public int SideLength { get; set; }

        public Triangle(int sideLength)
        {
            SideLength = sideLength;
        }

        public int GetCircumfence()
        {
            return SideLength * 3;
        }

        public double GetArea()
        {
            return Math.Sqrt(0.75) * Math.Pow(SideLength, 2);
        }
    }
}
