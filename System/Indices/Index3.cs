﻿namespace System
{
    /// <summary>
    /// Represents an index of the 3D variable size array
    /// </summary>
    [Serializable]
    public readonly struct Index3 : IEquatableReadOnlyStruct<Index3>, IComparableReadOnlyStruct<Index3>
    {
        public readonly int A;
        public readonly int B;
        public readonly int C;

        [Obsolete("This property has been deprecated. Use A instead.")]
        public int X => this.A;

        [Obsolete("This property has been deprecated. Use B instead.")]
        public int Y => this.B;

        [Obsolete("This property has been deprecated. Use C instead.")]
        public int Z => this.C;

        public Index3(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void Deconstruct(out int a, out int b, out int c)
        {
            a = this.A;
            b = this.B;
            c = this.C;
        }

        /// <summary>
        /// Converts to 1D index.
        /// </summary>
        /// <param name="lengthA">Length of the dimension <see cref="A"/> of the 3D array.</param>
        /// <param name="lengthB">Length of the dimension <see cref="B"/> of the 3D array.</param>
        /// <returns>
        /// <para>If any length is less than or equal to zero, returns zero.</para>
        /// <para>Otherwise, returns the converted value.</para>
        /// </returns>
        public int ToIndex1(int lengthA, int lengthB)
        {
            if (lengthA <= 0 || lengthB <= 0)
                return 0;

            return this.A + (this.B * lengthA) + (this.C * lengthA * lengthB);
        }

        public int ToIndex1(in Length2 length)
        {
            if (length.A <= 0 || length.B <= 0)
                return 0;

            return this.A + (this.B * length.A) + (this.C * length.A * length.B);
        }

        public override int GetHashCode()
        {
            var hashCode = 793064651;
            hashCode = hashCode * -1521134295 + this.A.GetHashCode();
            hashCode = hashCode * -1521134295 + this.B.GetHashCode();
            hashCode = hashCode * -1521134295 + this.C.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
            => obj is Index3 other &&
               this.A == other.A &&
               this.B == other.B &&
               this.C == other.C;

        public int CompareTo(Index3 other)
        {
            var comp = this.A.CompareTo(other.A);

            if (comp != 0)
                return comp;

            var comp1 = this.B.CompareTo(other.B);

            if (comp1 == 0)
                return this.C.CompareTo(other.C);

            return comp1;
        }

        public int CompareTo(in Index3 other)
        {
            var comp = this.A.CompareTo(other.A);

            if (comp != 0)
                return comp;

            var comp1 = this.B.CompareTo(other.B);

            if (comp1 == 0)
                return this.C.CompareTo(other.C);

            return comp1;
        }

        public bool Equals(Index3 other)
            => this.A == other.A && this.B == other.B && this.C == other.C;

        public bool Equals(in Index3 other)
            => this.A == other.A && this.B == other.B && this.C == other.C;

        public override string ToString()
            => $"({this.A}, {this.B}, {this.C})";

        /// <summary>
        /// Shorthand for writing <see cref="Index3"/>(0, 0, 0).
        /// </summary>
        public static Index3 Zero { get; } = new Index3(0, 0, 0);

        public static implicit operator Index3(in (int, int, int) value)
            => new Index3(value.Item1, value.Item2, value.Item3);

        public static Index3 operator +(in Index3 lhs, in Index3 rhs)
            => new Index3(lhs.A + rhs.A, lhs.B + rhs.B, lhs.C + rhs.C);

        public static Index3 operator -(in Index3 lhs, in Index3 rhs)
            => new Index3(lhs.A - rhs.A, lhs.B - rhs.B, lhs.C - rhs.C);

        public static Index3 operator -(in Index3 a)
            => new Index3(-a.A, -a.B, -a.C);

        public static Index3 operator *(in Index3 lhs, int rhs)
            => new Index3(lhs.A * rhs, lhs.B * rhs, lhs.C * rhs);

        public static Index3 operator *(int lhs, in Index3 rhs)
            => new Index3(lhs * rhs.A, lhs * rhs.B, lhs * rhs.C);

        public static Index3 operator /(in Index3 lhs, int rhs)
            => new Index3(lhs.A / rhs, lhs.B / rhs, lhs.C / rhs);

        public static bool operator ==(in Index3 lhs, in Index3 rhs)
            => lhs.A == rhs.A && lhs.B == rhs.B && lhs.C == rhs.C;

        public static bool operator !=(in Index3 lhs, in Index3 rhs)
            => lhs.A != rhs.A || lhs.B != rhs.B || lhs.C != rhs.C;

        /// <summary>
        /// Converts 1D index to 3D index.
        /// </summary>
        /// <param name="index1">1D index.</param>
        /// <param name="lengthA">Length of the dimension <see cref="A"/> of the 3D array.</param>
        /// <param name="lengthB">Length of the dimension <see cref="B"/> of the 3D array.</param>
        /// <returns>
        /// <para>If any length is less than or equal to zero, returns <see cref="Zero"/>.</para>
        /// <para>Otherwise, returns the converted value.</para>
        /// </returns>
        public static Index3 Convert(int index1, int lengthA, int lengthB)
        {
            if (lengthA <= 0 || lengthB <= 0)
                return Zero;

            var alengthB = lengthA * lengthB;
            var c = index1 / alengthB;
            var i_ab = index1 - (c * alengthB);
            var b = i_ab / lengthA;
            var a = i_ab % lengthA;

            return new Index3(a, b, c);
        }

        public static Index3 Convert(int index1, in Length2 length)
        {
            if (length.A <= 0 || length.B <= 0)
                return Zero;

            var alengthB = length.A * length.B;
            var c = index1 / alengthB;
            var i_ab = index1 - (c * alengthB);
            var b = i_ab / length.A;
            var a = i_ab % length.A;

            return new Index3(a, b, c);
        }
    }
}
