using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public struct Vector3
    {
        #region Fields
        float _x, _y, _z;
        readonly float _normalized, _magnitude, _sqrMagnitude;


        static Vector3 _forward = new Vector3(0, 0, 1);
        static Vector3 _back = new Vector3(0, 0, -1);
        static Vector3 _left = new Vector3(-1, 0, 0);
        static Vector3 _right = new Vector3(1, 0, 0);
        static Vector3 _up = new Vector3(0, -1, 0);
        static Vector3 _down = new Vector3(0, 1, 0);
        static Vector3 _one = new Vector3(1, 1, 1);
        static Vector3 _zero = new Vector3(0, 0, 0);
        #endregion

        #region Properties
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Z { get => _z; set => _z = value; }
        public float Magnitude { get => _magnitude; }
        public float Normalized { get => _normalized; }
        public float SqrMagnitude { get => _sqrMagnitude; }
        public Vector3 Front { get => _forward; set => _forward = value; }
        public Vector3 Back { get => _back; set => _back = value; }
        public Vector3 Left { get => _left; set => _left = value; }
        public Vector3 Right { get => _right; set => _right = value; }
        public Vector3 Up { get => _up; set => _up = value; }
        public Vector3 Down { get => _down; set => _down = value; }
        public Vector3 One { get => _one; set => _one = value; }
        public Vector3 Zero { get => _zero; set => _zero = value; }
        #endregion

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;

            _magnitude = (float)Math.Sqrt(x * x + y * y + z * z);
            _normalized = _magnitude / _magnitude;
            _sqrMagnitude = (float)Math.Sqrt(_magnitude);
        }

        #region Static Methods
        public static Vector3 Normalize(Vector3 normalize)
        {
            Vector3 normlizedVector3 = normalize / normalize;
            return normlizedVector3;
        }
        #endregion

        #region Methods
        public Vector3 Add(Vector3 newVector3)
        {
            Vector3 AddVector3 = new Vector3(X + newVector3.X, Y + newVector3.Y, Z + newVector3.Z);
            return AddVector3;
        }

        public Vector3 Sub(Vector3 newVector3)
        {
            Vector3 SubVector3 = new Vector3(X - newVector3.X, Y - newVector3.Y, Z - newVector3.Z);
            return SubVector3;
        }

        public Vector3 Set(Vector3 newVector3)
        {
            Vector3 replacedVector3 = newVector3;
            return replacedVector3;
        }

        public int GetDotProduct()
        {
            int dotPX;
            int dotPY;
            int dotPZ;

            dotPX = (int)Math.Round(X * X);
            dotPY = (int)Math.Round(Y * Y);
            dotPZ = (int)Math.Round(Z * Z);

            return dotPX + dotPY + dotPZ;
        }
        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            if (this == (Vector3)obj)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }
        public override int GetHashCode()
        {
            int hashCode = -1489584576;
            hashCode = hashCode * -1521134295 + _x.GetHashCode();
            hashCode = hashCode * -1521134295 + _y.GetHashCode();
            hashCode = hashCode * -1521134295 + _z.GetHashCode();
            hashCode = hashCode * -1521134295 + _normalized.GetHashCode();
            hashCode = hashCode * -1521134295 + _magnitude.GetHashCode();
            hashCode = hashCode * -1521134295 + _sqrMagnitude.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            hashCode = hashCode * -1521134295 + Magnitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Normalized.GetHashCode();
            hashCode = hashCode * -1521134295 + SqrMagnitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Front.GetHashCode();
            hashCode = hashCode * -1521134295 + Back.GetHashCode();
            hashCode = hashCode * -1521134295 + Left.GetHashCode();
            hashCode = hashCode * -1521134295 + Right.GetHashCode();
            hashCode = hashCode * -1521134295 + Up.GetHashCode();
            hashCode = hashCode * -1521134295 + Down.GetHashCode();
            hashCode = hashCode * -1521134295 + One.GetHashCode();
            hashCode = hashCode * -1521134295 + Zero.GetHashCode();
            return hashCode;
        }
        #endregion

        #region Operators
        public static Vector3 operator +(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 result = new Vector3(firstVector3.X + secondVector3.X, firstVector3.Y + secondVector3.Y, firstVector3.Z + secondVector3.Z);
            return result;
        }
        public static Vector3 operator -(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 result = new Vector3(firstVector3.X - secondVector3.X, firstVector3.Y - secondVector3.Y, firstVector3.Z - secondVector3.Z);
            return result;
        }
        public static Vector3 operator *(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 result = new Vector3(firstVector3.X * secondVector3.X, firstVector3.Y * secondVector3.Y, firstVector3.Z * secondVector3.Z);
            return result;
        }
        public static Vector3 operator /(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 result = new Vector3(firstVector3.X / secondVector3.X, firstVector3.Y / secondVector3.Y, firstVector3.Z / secondVector3.Z);
            return result;
        }
        public static bool operator ==(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 == secondVector3)
                return true;
            else
                return false;
        }
        public static bool operator !=(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 != secondVector3)
                return true;
            else
                return false;
        }
        public static bool operator >(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 > secondVector3)
                return true;
            else
                return false;
        }
        public static bool operator <(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 < secondVector3)
                return true;
            else
                return false;
        }
        public static bool operator >=(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 >= secondVector3)
                return true;
            else
                return false;
        }
        public static bool operator <=(Vector3 firstVector3, Vector3 secondVector3)
        {
            if (firstVector3 <= secondVector3)
                return true;
            else
                return false;
        }
        #endregion
    }
}