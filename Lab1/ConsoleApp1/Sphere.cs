using System;

namespace Model
{
    public class Sphere : IFigure
    {
        public double? R { get; set; }

        public Sphere(double? r = null)
        {
            R = r;
        }

        public double CalcV()
        {
            if (R == null)
                throw new ArgumentNullException(nameof(R));
            if (R <= 0)
                throw new ArgumentOutOfRangeException(nameof(R));

            return 4.0 / 3.0* Math.PI * R.Value * R.Value;
        }
    }
}
