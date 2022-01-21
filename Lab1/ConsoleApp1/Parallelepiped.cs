using System;

namespace Model
{
    public class Parallelepiped : IFigure
    {
        public double? A { get; set; }

        public double? B { get; set; }

        public double? C { get; set; }

        public Parallelepiped(double? a = null, double? b = null, double? c = null)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcV()
        {
            if (A == null)
                throw new ArgumentNullException(nameof(A));
            if (A <= 0)
                throw new ArgumentOutOfRangeException(nameof(A));
            if (B == null)
                throw new ArgumentNullException(nameof(B));
            if (B <= 0)
                throw new ArgumentOutOfRangeException(nameof(B));
            if (C == null)
                throw new ArgumentNullException(nameof(C));
            if (C <= 0)
                throw new ArgumentOutOfRangeException(nameof(C));

            return A.Value * B.Value * C.Value;
        }
    }
}
