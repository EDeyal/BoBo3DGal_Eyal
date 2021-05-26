using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Ridigbooty : Component
    {
        private float _velocity;
        private int _useGravity;
        private int _gravityScale;

        public float Velocity { get => _velocity; set => _velocity = value; }

        public Vector3 AddForce()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyConstantForce(Vector3 vector3, float amount)
        {
            throw new System.NotImplementedException();
        }
    }
}