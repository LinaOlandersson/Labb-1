namespace Labb_1
{
    internal class Circle
    {
        float _pi = 3.14f;

        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public float GetArea()
        {
            return Radius * Radius * _pi;
        }

        public float GetCircumfence()
        {
            return (Radius + Radius) * _pi; 
        }
        public double GetVolume()
        {
            return (4 * _pi * Math.Pow(Radius,3)/3);
        }
    }
}
