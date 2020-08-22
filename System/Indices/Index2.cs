﻿namespace System
{
    /// <summary>
    /// Represents an index of the 2D variable size array
    /// </summary>
    [Serializable]
    public readonly struct Index2 : IEquatableReadOnlyStruct<Index2>, IComparableReadOnlyStruct<Index2>
    {
        public readonly int A;
        public readonly int B;

        [Obsolete("This property has been deprecated. Use A instead.")]
        public int X => this.A;

        [Obsolete("This property has been deprecated. Use B instead.")]
        public int Y => this.B;

        public Index2(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public void Deconstruct(out int a, out int b)
        {
            a = this.A;
            b = this.B;
        }

        /// <summary>
        /// Converts to 1D index.
        /// </summary>
        /// <param name="lengthA">Length of the dimension <see cref="A"/> of the 2D array.</param>
        /// <returns>
        /// <para>If length is less than or equal to zero, returns zero.</para>
        /// <para>Otherwise, returns the converted value.</para>
        /// </returns>
        public int ToIndex1(int lengthA)
            => lengthA <= 0 ? 0 : this.A + this.B * lengthA;

        public override int GetHashCode()
        {
            var hashCode = -1817952719;
            hashCode = hashCode * -1521134295 + this.A.GetHashCode();
            hashCode = hashCode * -1521134295 + this.B.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
            => obj is Index2 other &&
               this.A == other.A &&
               this.B == other.B;

        public int CompareTo(Index2 other)
        {
            var comp = this.A.CompareTo(other.A);

            if (comp == 0)
                return this.B.CompareTo(other.B);

            return comp;
        }

        public int CompareTo(in Index2 other)
        {
            var comp = this.A.CompareTo(other.A);

            if (comp == 0)
                return this.B.CompareTo(other.B);

            return comp;
        }

        public bool Equals(Index2 other)
            => this.A == other.A && this.B == other.B;

        public bool Equals(in Index2 other)
            => this.A == other.A && this.B == other.B;

        public override string ToString()
            => $"({this.A}, {this.B})";

        /// <summary>
        /// Shorthand for writing <see cref="Index2"/>(0, 0).
        /// </summary>
        public static Index2 Zero { get; } = new Index2(0, 0);

        public static implicit operator Index2(in (int, int) value)
            => new Index2(value.Item1, value.Item2);

        public static Index2 operator +(in Index2 lhs, in Index2 rhs)
            => new Index2(lhs.A + rhs.A, lhs.B + rhs.B);

        public static Index2 operator -(in Index2 lhs, in Index2 rhs)
            => new Index2(lhs.A - rhs.A, lhs.B - rhs.B);

        public static Index2 operator -(in Index2 a)
            => new Index2(-a.A, -a.B);

        public static Index2 operator *(in Index2 lhs, int rhs)
            => new Index2(lhs.A * rhs, lhs.B * rhs);

        public static Index2 operator *(int lhs, in Index2 rhs)
            => new Index2(lhs * rhs.A, lhs * rhs.B);

        public static Index2 operator /(in Index2 lhs, int rhs)
            => new Index2(lhs.A / rhs, lhs.B / rhs);

        public static bool operator ==(in Index2 lhs, in Index2 rhs)
            => lhs.A == rhs.A && lhs.B == rhs.B;

        public static bool operator !=(in Index2 lhs, in Index2 rhs)
            => lhs.A != rhs.A || lhs.B != rhs.B;

        public static implicit operator Index2(in Index3 value)
            => new Index2(value.A, value.B);

        /// <summary>
        /// Converts 1D index to 2D index.
        /// </summary>
        /// <param name="index1">1D index.</param>
        /// <param name="lengthA">Length of the dimension <see cref="A"/> of the 2D array.</param>
        /// <returns>
        /// <para>If length is less than or equal to zero, returns <see cref="Zero"/>.</para>
        /// <para>Otherwise, returns the converted value.</para>
        /// </returns>
        public static Index2 Convert(int index1, int lengthA)
            => lengthA <= 0 ? Zero: new Index2(index1 % lengthA, index1 / lengthA);
    }
}
