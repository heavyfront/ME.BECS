//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace ME.BECS.FixedPoint
{
    [System.Serializable]
    public partial struct int2x4 : System.IEquatable<int2x4>, IFormattable
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;
        public int2 c3;

        /// <summary>int2x4 zero value.</summary>
        public static readonly int2x4 zero;

        /// <summary>Constructs a int2x4 matrix from four int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a int2x4 matrix from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13)
        {
            this.c0 = new int2(m00, m10);
            this.c1 = new int2(m01, m11);
            this.c2 = new int2(m02, m12);
            this.c3 = new int2(m03, m13);
        }

        /// <summary>Constructs a int2x4 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a int2x4 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(bool v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v);
            this.c1 = math.select(new int2(0), new int2(1), v);
            this.c2 = math.select(new int2(0), new int2(1), v);
            this.c3 = math.select(new int2(0), new int2(1), v);
        }

        /// <summary>Constructs a int2x4 matrix from a bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(bool2x4 v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v.c0);
            this.c1 = math.select(new int2(0), new int2(1), v.c1);
            this.c2 = math.select(new int2(0), new int2(1), v.c2);
            this.c3 = math.select(new int2(0), new int2(1), v.c3);
        }

        /// <summary>Constructs a int2x4 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(uint v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
            this.c3 = (int2)v;
        }

        /// <summary>Constructs a int2x4 matrix from a uint2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(uint2x4 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
            this.c3 = (int2)v.c3;
        }

        /// <summary>Constructs a int2x4 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(sfloat v)
        {
            this.c0 = new int2(v);
            this.c1 = new int2(v);
            this.c2 = new int2(v);
            this.c3 = new int2(v);
        }

        /// <summary>Constructs a int2x4 matrix from a float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(float2x4 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
            this.c3 = (int2)v.c3;
        }


        /// <summary>Implicitly converts a single int value to a int2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x4(int v) { return new int2x4(v); }

        /// <summary>Explicitly converts a single bool value to a int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(bool v) { return new int2x4(v); }

        /// <summary>Explicitly converts a bool2x4 matrix to a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(bool2x4 v) { return new int2x4(v); }

        /// <summary>Explicitly converts a single uint value to a int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(uint v) { return new int2x4(v); }

        /// <summary>Explicitly converts a uint2x4 matrix to a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(uint2x4 v) { return new int2x4(v); }

        /// <summary>Explicitly converts a single float value to a int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(sfloat v) { return new int2x4(v); }

        /// <summary>Explicitly converts a float2x4 matrix to a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(float2x4 v) { return new int2x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int lhs, int2x4 rhs) { return new int2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int lhs, int2x4 rhs) { return new int2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int lhs, int2x4 rhs) { return new int2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int lhs, int2x4 rhs) { return new int2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int lhs, int2x4 rhs) { return new int2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ++ (int2x4 val) { return new int2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator -- (int2x4 val) { return new int2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int lhs, int2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int lhs, int2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int lhs, int2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int lhs, int2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 val) { return new int2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 val) { return new int2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise left shift operation on an int2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator << (int2x4 x, int n) { return new int2x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator >> (int2x4 x, int n) { return new int2x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int lhs, int2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int lhs, int2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ~ (int2x4 val) { return new int2x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int lhs, int2x4 rhs) { return new int2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int lhs, int2x4 rhs) { return new int2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int lhs, int2x4 rhs) { return new int2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the int2 element at a specified index.</summary>
        unsafe public ref int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int2x4* array = &this) { return ref ((int2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the int2x4 is equal to a given int2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the int2x4 is equal to a given int2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int2x4)o); }


        /// <summary>Returns a hash code for the int2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the int2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int2x4 matrix constructed from four int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3) { return new int2x4(c0, c1, c2, c3); }

        /// <summary>Returns a int2x4 matrix constructed from from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13)
        {
            return new int2x4(m00, m01, m02, m03,
                              m10, m11, m12, m13);
        }

        /// <summary>Returns a int2x4 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int v) { return new int2x4(v); }

        /// <summary>Returns a int2x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(bool v) { return new int2x4(v); }

        /// <summary>Return a int2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(bool2x4 v) { return new int2x4(v); }

        /// <summary>Returns a int2x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(uint v) { return new int2x4(v); }

        /// <summary>Return a int2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(uint2x4 v) { return new int2x4(v); }

        /// <summary>Returns a int2x4 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(sfloat v) { return new int2x4(v); }

        /// <summary>Return a int2x4 matrix constructed from a float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(float2x4 v) { return new int2x4(v); }

        /// <summary>Return the int4x2 transpose of a int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 transpose(int2x4 v)
        {
            return int4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a int2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2x4 v)
        {
            return csum(asuint(v.c0) * uint2(0x7AA07CD3u, 0xAF642BA9u) +
                        asuint(v.c1) * uint2(0xA8F2213Bu, 0x9F3FDC37u) +
                        asuint(v.c2) * uint2(0xAC60D0C3u, 0x9263662Fu) +
                        asuint(v.c3) * uint2(0xE69626FFu, 0xBD010EEBu)) + 0x9CEDE1D1u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a int2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(int2x4 v)
        {
            return (asuint(v.c0) * uint2(0x43BE0B51u, 0xAF836EE1u) +
                    asuint(v.c1) * uint2(0xB130C137u, 0x54834775u) +
                    asuint(v.c2) * uint2(0x7C022221u, 0xA2D00EDFu) +
                    asuint(v.c3) * uint2(0xA8977779u, 0x9F1C739Bu)) + 0x4B1BD187u;
        }

    }
}
