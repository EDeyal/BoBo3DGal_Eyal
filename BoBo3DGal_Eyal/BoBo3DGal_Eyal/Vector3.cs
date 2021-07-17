using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public struct Vector3
    {
        float _x, _y, _z;

        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Z { get => _z; set => _z = value; }

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public Vector3 Add(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 AddVector3 = new Vector3(firstVector3.X + secondVector3.X, firstVector3.Y + secondVector3.Y, firstVector3.Z + secondVector3.Z);
            return AddVector3;
        }

        public Vector3 Sub(Vector3 firstVector3, Vector3 secondVector3)
        {
            Vector3 SubVector3 = new Vector3(firstVector3.X - secondVector3.X, firstVector3.Y - secondVector3.Y, firstVector3.Z - secondVector3.Z);
            return SubVector3;
        }

        public int GetDotProduct(Vector3 firstVector3, Vector3 secondVector3)
        {
            int dotPX;
            int dotPY;
            int dotPZ;

            dotPX = (int)Math.Round(firstVector3._x * secondVector3._x);
            dotPY = (int)Math.Round(firstVector3._y * secondVector3._y);
            dotPZ = (int)Math.Round(firstVector3._z * secondVector3._z);

            return dotPX + dotPY + dotPZ;
        }

        public float GetMagnitude(Vector3 vector3)
        {
            float magX;
            float magY;
            float magZ;

            magX = (float)Math.Round(vector3._x * vector3._x);
            magY = (float)Math.Round(vector3._y * vector3._y);
            magZ = (float)Math.Round(vector3._z * vector3._z);

            float _magnitude = (float)Math.Sqrt(magX + magY + magZ);
            return _magnitude;
        }

        public Vector3 Normalize()
        {
            Vector3 normlizedVector3 = new Vector3(X / GetMagnitude(this), Y / GetMagnitude(this), Z / GetMagnitude(this)) ;
            return normlizedVector3;
        }
        public override string ToString()
        {
            return $"Position: {X},{Y},{Z}";
        }
    }
}