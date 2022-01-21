using System;

namespace Model
{
    [Serializable]
    public class Pyramid : IFigure
    {
        public double? S { get; set; }

        public double? H { get; set; }

        public Pyramid(double? s = null, double? h = null)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(S));
            if (s <= 0)
                throw new ArgumentOutOfRangeException(nameof(S));
            if (h == null)
                throw new ArgumentNullException(nameof(H));
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(H));

            S = s;
            H = h;
        }

        public double CalcV()
        {
            return 1.0 / 3.0 * S.Value * H.Value;
        }

        public override string ToString()
        {
            return $"Pyramid, S: {S}, H: {H}";
        }
    }
}
