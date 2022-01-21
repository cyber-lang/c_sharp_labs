using System;

namespace Model
{
    [Serializable]
    public class Parallelepiped : IFigure
    {
        public double? A { get; set; }

        public double? B { get; set; }

        public double? C { get; set; }

        public Parallelepiped(double? a = null, double? b = null, double? c = null)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(A));
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(A));
            if (b == null)
                throw new ArgumentNullException(nameof(B));
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(B));
            if (c == null)
                throw new ArgumentNullException(nameof(C));
            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(C));

            A = a;
            B = b;
            C = c;
        }

        public double CalcV()
        {
            return A.Value * B.Value * C.Value;
        }

        public override string ToString()
        {
            return $"Parallelepiped, A: {A}, B: {B}, C: {C}";
        }
    }
}
