﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public struct Vector3
    {
        #region Fields
        float _x, _y, _z;
        #endregion

        #region Properties
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Z { get => _z; set => _z = value; }
        #endregion

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

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

        public float GetMagnitude()
        {
            float magX;
            float magY;
            float magZ;

            magX = (float)Math.Round(X * X);
            magY = (float)Math.Round(Y * Y);
            magZ = (float)Math.Round(Z * Z);

            float _magnitude = (float)Math.Sqrt(magX + magY + magZ);
            return _magnitude;
        }

        public Vector3 Normalize()
        {
            Vector3 normlizedVector3 = new Vector3(X / GetMagnitude(), Y / GetMagnitude(), Z / GetMagnitude()) ;
            return normlizedVector3;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }
        #endregion
    }
}