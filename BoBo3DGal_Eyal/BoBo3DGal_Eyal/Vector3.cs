using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public struct Vector3
    {
        float _x, _y, _z;

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void AddVector3(Vector3 firstVector3, Vector3 secondVector3)
        {
            throw new System.NotImplementedException();
        }

        public Vector3 SubVector3(Vector3 firstVector3, Vector3 secondVector3)
        {
            throw new System.NotImplementedException();
        }

        public Vector3 Normalize(Vector3 vector3)
        {
            throw new System.NotImplementedException();
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
    }
}