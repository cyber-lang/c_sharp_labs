using System;

namespace Model
{
    [Serializable]
    public class Sphere : IFigure
    {
        public double? R { get; set; }

        public Sphere(double? r = null)
        {
            if (r == null)
                throw new ArgumentNullException(nameof(R));
            if (r <= 0)
                throw new ArgumentOutOfRangeException(nameof(R));

            R = r;
        }

        public double CalcV()
        {
            return 4.0 / 3.0* Math.PI * R.Value * R.Value;
        }

        public override string ToString()
        {
            return $"Sphere, R: {R}";
        }
    }
}
