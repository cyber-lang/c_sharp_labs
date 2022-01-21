using System;

namespace Model
{
    public class Pyramid : IFigure
    {
        public double? S { get; set; }

        public double? H { get; set; }

        public Pyramid(double? s = null, double? h = null)
        {
            S = s;
            H = h;
        }

        public double CalcV()
        {
            if (S == null)
                throw new ArgumentNullException(nameof(S));
            if (S <= 0)
                throw new ArgumentOutOfRangeException(nameof(S));
            if (H == null)
                throw new ArgumentNullException(nameof(H));
            if (H <= 0)
                throw new ArgumentOutOfRangeException(nameof(H));

            return 1.0 / 3.0 * S.Value * H.Value;
        }
    }
}
